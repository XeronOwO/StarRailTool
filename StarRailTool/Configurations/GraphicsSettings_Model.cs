using Microsoft.Win32;
using Newtonsoft.Json;
using StarRailTool.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarRailTool.Configurations
{
	internal class GraphicsSettings_Model
	{
		#region 静态

		static GraphicsSettings_Model()
		{
			Load();
		}

		private static GraphicsSettings_Model instance = new();

		public static GraphicsSettings_Model Instance
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
		private const string ModelPattern = "GraphicsSettings_Model.*";
		private static readonly Regex modelRegex = new(ModelPattern);

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
			var modelNames = from name in starRail.GetValueNames()
									where modelRegex.IsMatch(name)
									select name;
			if (!modelNames.Any())
			{
				throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, starRailName, ModelPattern)));
			}
			var modelName = modelNames.First();

			// HKEY_CURRENT_USER\Software\miHoYo\崩坏：星穹铁道\GraphicsSettings_Model_h2986158309
			var bytes = starRail.GetValue(modelName) as byte[] ?? throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, starRailName, modelName)));
			var str = Encoding.UTF8.GetString(bytes);
			LoadFromString(str);
		}

		public static void LoadFromString(string str)
		{
			instance = JsonConvert.DeserializeObject<GraphicsSettings_Model>(str) ?? throw new Exception(string.Format(Strings.ConversionFailed, str, "PCResolution"));
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
			var modelNames = from name in starRail.GetValueNames()
							 where modelRegex.IsMatch(name)
							 select name;
			if (!modelNames.Any())
			{
				throw new Exception(string.Format(Strings.RegistryPathNotFound, Path.Combine(UserKeyPath, MiHoYoKeyPath, starRailName, ModelPattern)));
			}
			var modelName = modelNames.First();

			// HKEY_CURRENT_USER\Software\miHoYo\崩坏：星穹铁道\GraphicsSettings_Model_h2986158309
			var list = new List<byte>(Encoding.UTF8.GetBytes(instance.ToString()))
			{
				0,
			};
			starRail.SetValue(modelName, list.ToArray(), RegistryValueKind.Binary);
		}

		#endregion

		#region 动态

		[JsonProperty("FPS")]
		public int FPS;

		[JsonProperty("EnableVSync")]
		public bool EnableVSync;

		[JsonProperty("RenderScale")]
		public float RenderScale;

		[JsonProperty("ResolutionQuality")]
		public int ResolutionQuality;

		[JsonProperty("ShadowQuality")]
		public int ShadowQuality;

		[JsonProperty("LightQuality")]
		public int LightQuality;

		[JsonProperty("CharacterQuality")]
		public int CharacterQuality;

		[JsonProperty("EnvDetailQuality")]
		public int EnvDetailQuality;

		[JsonProperty("ReflectionQuality")]
		public int ReflectionQuality;

		[JsonProperty("SFXQuality")]
		public int SFXQuality;

		[JsonProperty("BloomQuality")]
		public int BloomQuality;

		[JsonProperty("AAMode")]
		public int AAMode;

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this, Formatting.None);
		}

		#endregion
	}
}
