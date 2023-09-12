using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StarRailTool.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarRailTool.Configurations
{
	internal class GraphicsSettings_PCResolution
	{
		#region 静态

		static GraphicsSettings_PCResolution()
		{
			Load();
		}

		private static GraphicsSettings_PCResolution instance = new();

		public static GraphicsSettings_PCResolution Instance
		{
			get
			{
				return instance;
			}
		}

		private const string UserKeyPath = @"HKEY_CURRENT_USER";
		private const string MiHoYoKeyPath = @"Software\miHoYo";
		private const string StarRailRegexPattern = "(.*星穹铁道.*)|(.*Star.*Rail.*)";
		private static readonly Regex starRailRegex = new(StarRailRegexPattern);
		private const string PCResolutionPattern = "GraphicsSettings_PCResolution.*";
		private static readonly Regex pcResolutionRegex = new(PCResolutionPattern);

		public static void Load()
		{
			// HKEY_CURRENT_USER
			var currentUser = Registry.CurrentUser;

			// HKEY_CURRENT_USER\Software\miHoYo
			using var miHoYo = currentUser.OpenSubKey(MiHoYoKeyPath) ?? throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath)));
			var starRailNames = from name in miHoYo.GetSubKeyNames()
								where starRailRegex.IsMatch(name)
								select name;
			if (!starRailNames.Any())
			{
				throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, StarRailRegexPattern)));
			}
			var starRailName = starRailNames.First();

			// HKEY_CURRENT_USER\Software\miHoYo\崩坏：星穹铁道
			using var starRail = miHoYo.OpenSubKey(starRailName) ?? throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, starRailName)));
			var pcResolutionNames = from name in starRail.GetValueNames()
									where pcResolutionRegex.IsMatch(name)
									select name;
			if (!pcResolutionNames.Any())
			{
				throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, starRailName, PCResolutionPattern)));
			}
			var pcResolutionName = pcResolutionNames.First();

			// HKEY_CURRENT_USER\Software\miHoYo\崩坏：星穹铁道\GraphicsSettings_PCResolution_h431323223
			var bytes = starRail.GetValue(pcResolutionName) as byte[] ?? throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, starRailName, pcResolutionName)));
			var str = Encoding.UTF8.GetString(bytes);
			LoadFromString(str);
		}

		public static void LoadFromString(string str)
		{
			instance = JsonConvert.DeserializeObject<GraphicsSettings_PCResolution>(str) ?? throw new Exception(string.Format(Strings.ConversionFailed, str, "PCResolution"));
		}

		public static void Save()
		{
			// HKEY_CURRENT_USER
			var currentUser = Registry.CurrentUser;

			// HKEY_CURRENT_USER\Software\miHoYo
			using var miHoYo = currentUser.OpenSubKey(MiHoYoKeyPath, true) ?? throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath)));
			var starRailNames = from name in miHoYo.GetSubKeyNames()
								where starRailRegex.IsMatch(name)
								select name;
			if (!starRailNames.Any())
			{
				throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, StarRailRegexPattern)));
			}
			var starRailName = starRailNames.First();

			// HKEY_CURRENT_USER\Software\miHoYo\崩坏：星穹铁道
			using var starRail = miHoYo.OpenSubKey(starRailName, true) ?? throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, starRailName)));
			var pcResolutionNames = from name in starRail.GetValueNames()
									where pcResolutionRegex.IsMatch(name)
									select name;
			if (!pcResolutionNames.Any())
			{
				throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, starRailName, PCResolutionPattern)));
			}
			var pcResolutionName = pcResolutionNames.First();

			// HKEY_CURRENT_USER\Software\miHoYo\崩坏：星穹铁道\GraphicsSettings_PCResolution_h431323223
			var list = new List<byte>(Encoding.UTF8.GetBytes(instance.ToString()))
			{
				0,
			};
			starRail.SetValue(pcResolutionName, list.ToArray(), RegistryValueKind.Binary);
		}

		#endregion

		#region 动态

		[JsonProperty("height")]
		public int Height;

		[JsonProperty("width")]
		public int Width;

		[JsonProperty("isFullScreen")]
		public bool IsFullScreen;

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this, Formatting.None);
		}

		#endregion
	}
}
