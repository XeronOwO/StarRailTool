using StarRailTool.Configurations;
using StarRailTool.Resources;
using StarRailTool.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace StarRailTool.WinForms
{
	/// <summary>
	/// 主对话框
	/// </summary>
	public partial class MainForm : Form
	{
		#region 窗体

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			btnGameSettingsSave.AddUACIcon();

			txtAbout.Text =
$@"StarRailTool v{Assembly.GetExecutingAssembly().GetName().Version}

https://github.com/XeronOwO/StarRailTool

License:
--------------------------------------------------
MIT License
Copyright (c) 2023 XeronOwO

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
--------------------------------------------------

Dependencies:
--------------------------------------------------
Newtonsoft.Json
--------------------------------------------------
https://github.com/JamesNK/Newtonsoft.Json

Copyright (c) 2007 James Newton-King

Licensed under the MIT:
https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md

--------------------------------------------------
commandline
--------------------------------------------------
https://github.com/commandlineparser/commandline

Copyright (c) 2005 - 2015 Giacomo Stelluti Scala & Contributors

Licensed under the MIT:
https://github.com/commandlineparser/commandline/blob/master/License.md
";
		}

		private void btnGameSettingsSave_Click(object sender, EventArgs e)
		{
			SaveGameSettings();
		}

		private void btnGameSettingsReset_Click(object sender, EventArgs e)
		{
			LoadGameSettings();
		}

		#endregion

		#region 抽卡链接

		private void btnGachaToolGetGachaLink_Click(object sender, EventArgs e)
		{
			try
			{
				txtGachaToolGachaLink.Text = GachaLinkHelper.GetGachaLink();

				Invoke(async () =>
				{
					if (await GachaLinkHelper.CheckValidityAsync(txtGachaToolGachaLink.Text))
					{
						lblGachaToolGachaLinkStatus.Text = Strings.ValidGachaLink;
						lblGachaToolGachaLinkStatus.ForeColor = Color.DarkGreen;
					}
					else
					{
						lblGachaToolGachaLinkStatus.Text = Strings.InvalidGachaLink;
						lblGachaToolGachaLinkStatus.ForeColor = Color.DarkRed;
					}
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnGachaToolCopyGachaLink_Click(object sender, EventArgs e)
		{
			if (txtGachaToolGachaLink.Text.Length == 0)
			{
				return;
			}

			Clipboard.SetText(txtGachaToolGachaLink.Text);
		}

		#endregion

		#region 游戏设置

		private bool isGameSettingsInited = false;

		private void tbcMainTab_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tbcMainTab.SelectedTab == tbpGameSettings)
			{
				if (!isGameSettingsInited)
				{
					isGameSettingsInited = true;
					LoadGameSettings();
				}
			}
		}

		private void LoadGameSettings()
		{
			try
			{
				GraphicsSettings_PCResolution.Load();
				txtGameSettingsHeight.Text = GraphicsSettings_PCResolution.Instance.Height.ToString();
				txtGameSettingsWidth.Text = GraphicsSettings_PCResolution.Instance.Width.ToString();
				chkGameSettingsFullScreen.Checked = GraphicsSettings_PCResolution.Instance.IsFullScreen;

				GraphicsSettings_Model.Load();
				cmbGameSettingsFPS.Text = GraphicsSettings_Model.Instance.FPS.ToString();
				chkGameSettingsEnableVSync.Checked = GraphicsSettings_Model.Instance.EnableVSync;
				cmbGameSettingsRenderScale.Text = GraphicsSettings_Model.Instance.RenderScale.ToString();
				cmbGameSettingsShadowQuality.SelectedIndex = GraphicsSettings_Model.Instance.ShadowQuality - 2;
				cmbGameSettingsReflectionQuality.SelectedIndex = GraphicsSettings_Model.Instance.ReflectionQuality - 1;
				cmbGameSettingsCharacterQuality.SelectedIndex = GraphicsSettings_Model.Instance.CharacterQuality - 3;
				cmbGameSettingsEnvDetailQuality.SelectedIndex = GraphicsSettings_Model.Instance.EnvDetailQuality - 1;
				cmbGameSettingsSFXQuality.SelectedIndex = GraphicsSettings_Model.Instance.SFXQuality - 1;
				cmbGameSettingsBloomQuality.SelectedIndex = GraphicsSettings_Model.Instance.BloomQuality;
				cmbGameSettingsAAMode.SelectedIndex = GraphicsSettings_Model.Instance.AAMode;
				cmbGameSettingsLightQuality.SelectedIndex = GraphicsSettings_Model.Instance.LightQuality - 1;
			}
			catch (Exception e)
			{
				MessageBox.Show($"{Strings.GraphicsSettingsNotFound}\n{e}", Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SaveGameSettings()
		{
			try
			{
				// FPS 120 BUG Warning
				if (int.Parse(cmbGameSettingsFPS.Text) == 120)
				{
					if (DialogResult.No == MessageBox.Show(Strings.FPS120Warning, Strings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
					{
						return;
					}
				}

				GraphicsSettings_PCResolution.Instance.Height = int.Parse(txtGameSettingsHeight.Text);
				GraphicsSettings_PCResolution.Instance.Width = int.Parse(txtGameSettingsWidth.Text);
				GraphicsSettings_PCResolution.Instance.IsFullScreen = chkGameSettingsFullScreen.Checked;

				GraphicsSettings_Model.Instance.FPS = int.Parse(cmbGameSettingsFPS.Text);
				GraphicsSettings_Model.Instance.EnableVSync = chkGameSettingsEnableVSync.Checked;
				GraphicsSettings_Model.Instance.RenderScale = float.Parse(cmbGameSettingsRenderScale.Text);
				GraphicsSettings_Model.Instance.ShadowQuality = cmbGameSettingsShadowQuality.SelectedIndex + 1;
				GraphicsSettings_Model.Instance.ReflectionQuality = cmbGameSettingsReflectionQuality.SelectedIndex + 1;
				GraphicsSettings_Model.Instance.CharacterQuality = cmbGameSettingsCharacterQuality.SelectedIndex + 2;
				GraphicsSettings_Model.Instance.EnvDetailQuality = cmbGameSettingsEnvDetailQuality.SelectedIndex + 1;
				GraphicsSettings_Model.Instance.SFXQuality = cmbGameSettingsSFXQuality.SelectedIndex + 1;
				GraphicsSettings_Model.Instance.BloomQuality = cmbGameSettingsBloomQuality.SelectedIndex;
				GraphicsSettings_Model.Instance.AAMode = cmbGameSettingsAAMode.SelectedIndex;
				GraphicsSettings_Model.Instance.LightQuality = cmbGameSettingsLightQuality.SelectedIndex + 1;

				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					GraphicsSettingsHelper.SaveDirectly();
				}
				else
				{
					GraphicsSettingsHelper.SaveRunAs();
				}

				MessageBox.Show(Strings.SaveGraphicsSettingsSuccessfully, Strings.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString(), Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion
	}
}
