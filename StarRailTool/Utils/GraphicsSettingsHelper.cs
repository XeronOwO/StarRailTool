using StarRailTool.Configurations;
using StarRailTool.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarRailTool.Utils
{
	internal static class GraphicsSettingsHelper
	{
		public static void SaveDirectly()
		{
			GraphicsSettings_PCResolution.Save();
			GraphicsSettings_Model.Save();
		}

		public static void SaveRunAs()
		{
			var startInfo = new ProcessStartInfo
			{
				UseShellExecute = true,
				WorkingDirectory = Environment.CurrentDirectory,
				FileName = Application.ExecutablePath,
				Verb = "runas",
				Arguments = $"--SetPCResolution={GraphicsSettings_PCResolution.Instance} --SetModel={GraphicsSettings_Model.Instance}",
			};

			using var process = Process.Start(startInfo) ?? throw new Exception(Strings.CreateProcessFailed);
			process.WaitForExit();

			if (process.ExitCode != 0)
			{
				throw new Exception(string.Format(Strings.ProcessExitedWithNonzero, process.ExitCode));
			}
		}
	}
}
