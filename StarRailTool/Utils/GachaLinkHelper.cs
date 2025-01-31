﻿using Newtonsoft.Json.Linq;
using StarRailTool.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarRailTool.Utils
{
	internal static class GachaLinkHelper
	{
		private const string StarRailRegexPattern = "(.*星穹铁道.*)|(.*Star.*Rail.*)";
		private static readonly Regex starRailRegex = new(StarRailRegexPattern);

		private static string GetGameLog()
		{
			var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			var miHoYo = Path.Combine(appData, @"..\LocalLow\miHoYo");
			if (!Directory.Exists(miHoYo))
			{
				throw new Exception(string.Format(Strings.PathNotFound, miHoYo));
			}
			var starRailNames = from dir in Directory.GetDirectories(miHoYo)
						   where starRailRegex.IsMatch(dir)
						   select dir;
			if (!starRailNames.Any())
			{
				throw new Exception(string.Format(Strings.PathNotFound, Path.Combine(miHoYo, StarRailRegexPattern)));
			}

			return Path.Combine(starRailNames.First(), "Player.log");
		}

		private const string GameDirectoryPattern = "Loading player data from .*/StarRail_Data";
		private static readonly Regex gameDirectoryRegex = new(GameDirectoryPattern);

		private static string GetGameDirectory()
		{
			var match = gameDirectoryRegex.Match(File.ReadAllText(GetGameLog()));
			if (!match.Success)
			{
				throw new Exception(Strings.GetGameDirectoryFailed);
			}

			return match.Value[25..^14];
		}

		private static string GetData2FilePath()
		{
			var webCachesDirectoryInfo = new DirectoryInfo(Path.Combine(GetGameDirectory(), @"StarRail_Data\webCaches"));
			if (!webCachesDirectoryInfo.Exists)
			{
				throw new Exception(string.Format(Strings.PathNotFound, webCachesDirectoryInfo.FullName));
			}

			var verionList = new List<Version>();
			foreach (var directoryInfo in webCachesDirectoryInfo.GetDirectories())
			{
				if (Version.TryParse(directoryInfo.Name, out Version? version))
				{
					verionList.Add(version);
				}
			}

			var maxVersion = verionList.Max();
			if (maxVersion == null)
			{
				throw new Exception(string.Format(Strings.PathNotFound, Path.Combine(webCachesDirectoryInfo.FullName, "{Version}")));
			}

			var path = Path.Combine(webCachesDirectoryInfo.FullName, maxVersion.ToString(), @"Cache\Cache_Data\data_2");
			if (!File.Exists(path))
			{
				throw new Exception(string.Format(Strings.PathNotFound, path));
			}

			return path;
		}

		public static List<int> IndexOfByteArray(byte[] data, byte[] pattern)
		{
			var matchedPos = new List<int>();

			if (data.Length == 0 || data.Length < pattern.Length) return matchedPos;

			int end = data.Length - pattern.Length;
			bool matched = false;

			for (int i = 0; i <= end; i++)
			{
				for (int j = 0; j < pattern.Length || !(matched = (j == pattern.Length)); j++)
				{
					if (data[i + j] != pattern[j]) break;
				}
				if (matched)
				{
					matched = false;
					matchedPos.Add(i);
				}
			}
			return matchedPos;
		}

		public static string GetGachaLink()
		{
			var bytes = File.ReadAllBytes(GetData2FilePath());
			var keyWord = "authkey_ver";
			var indexes = IndexOfByteArray(bytes, Encoding.UTF8.GetBytes(keyWord));
			if (!indexes.Any())
			{
				throw new Exception(Strings.GetGachaLinkFailed);
			}

			var list = new List<byte>();
			for (int i = indexes.Last(); i < bytes.Length; i++)
			{
				if (bytes[i] == 0)
				{
					break;
				}
				list.Add(bytes[i]);
			}

			return "https://public-operation-hkrpg.mihoyo.com/common/gacha_record/api/getGachaLog?"
				+ Encoding.UTF8.GetString(list.ToArray());
		}

		public static async Task<bool> CheckValidityAsync(string link)
		{
			using var client = new HttpClient();
			using var response = await client.GetAsync(link);
			response.EnsureSuccessStatusCode();
			var str = await response.Content.ReadAsStringAsync();
			var json = JObject.Parse(str);
			var retcode = (int?)json["retcode"] ?? throw new Exception();
			if (retcode != 0)
			{
				return false;
			}

			return true;
		}
	}
}
