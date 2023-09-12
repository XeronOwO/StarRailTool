using CommandLine;
using StarRailTool.Configurations;
using StarRailTool.WinForms;

namespace StarRailTool
{
	internal static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			// 处理命令行参数
			Parser.Default.ParseArguments<Options>(args).WithParsed(OnRun).WithNotParsed(OnError);
		}

		#region 命令行处理

		private class Options
		{
			[Option("SetPCResolution", Default = null, Required = false, HelpText = "Set GraphicsSettings_PCResolution")]
			public string? SetPCResolution { get; set; }

			[Option("SetModel", Default = null, Required = false, HelpText = "Set GraphicsSettings_Model")]
			public string? SetModel { get; set; }
		}

		private static void OnRun(Options options)
		{
			var startForm = true;

			if (options.SetPCResolution != null)
			{
				try
				{
					GraphicsSettings_PCResolution.LoadFromString(options.SetPCResolution);
					GraphicsSettings_PCResolution.Save();
				}
				catch (Exception)
				{
					Environment.ExitCode = -1;
				}

				startForm = false;
			}

			if (options.SetModel != null)
			{
				try
				{
					GraphicsSettings_Model.LoadFromString(options.SetModel);
					GraphicsSettings_Model.Save();
				}
				catch (Exception)
				{
					Environment.ExitCode = -1;
				}

				startForm = false;
			}

			// 启动窗体
			if (startForm)
			{
				ApplicationConfiguration.Initialize();
				Application.Run(new MainForm());
			}
		}
		private static void OnError(IEnumerable<Error> errors)
		{
			Environment.ExitCode = -1;
		}

		#endregion
	}
}