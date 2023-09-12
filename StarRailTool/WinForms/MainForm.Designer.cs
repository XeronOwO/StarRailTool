namespace StarRailTool.WinForms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			tbcMainTab = new TabControl();
			tbpGachaTool = new TabPage();
			btnGachaToolCopyGachaLink = new Button();
			lblGachaToolGachaLinkStatus = new Label();
			txtGachaToolGachaLink = new TextBox();
			btnGachaToolGetGachaLink = new Button();
			tbpGameSettings = new TabPage();
			flwGameSettingsButtons = new FlowLayoutPanel();
			btnGameSettingsSave = new Button();
			btnGameSettingsReset = new Button();
			flwGameSettingsLightQuality = new FlowLayoutPanel();
			lblGameSettingsLightQuality = new Label();
			cmbGameSettingsLightQuality = new ComboBox();
			flwGameSettingsAAMode = new FlowLayoutPanel();
			lblGameSettingsAAMode = new Label();
			cmbGameSettingsAAMode = new ComboBox();
			flwGameSettingsBloomQuality = new FlowLayoutPanel();
			lblGameSettingsBloomQuality = new Label();
			cmbGameSettingsBloomQuality = new ComboBox();
			flwGameSettingsSFXQuality = new FlowLayoutPanel();
			lblGameSettingsSFXQuality = new Label();
			cmbGameSettingsSFXQuality = new ComboBox();
			flwGameSettingsEnvDetailQuality = new FlowLayoutPanel();
			lblGameSettingsEnvDetailQuality = new Label();
			cmbGameSettingsEnvDetailQuality = new ComboBox();
			flwGameSettingsCharacterQuality = new FlowLayoutPanel();
			lblGameSettingsCharacterQuality = new Label();
			cmbGameSettingsCharacterQuality = new ComboBox();
			flwGameSettingsReflectionQuality = new FlowLayoutPanel();
			lblGameSettingsReflectionQuality = new Label();
			cmbGameSettingsReflectionQuality = new ComboBox();
			flwGameSettingsShadowQuality = new FlowLayoutPanel();
			lblGameSettingsShadowQuality = new Label();
			cmbGameSettingsShadowQuality = new ComboBox();
			flwGameSettingsPCResolution = new FlowLayoutPanel();
			lblGameSettingsHeight = new Label();
			txtGameSettingsHeight = new TextBox();
			lblGameSettingsWidth = new Label();
			txtGameSettingsWidth = new TextBox();
			chkGameSettingsFullScreen = new CheckBox();
			flwGameSettingsRenderScale = new FlowLayoutPanel();
			lblGameSettingsRenderScale = new Label();
			cmbGameSettingsRenderScale = new ComboBox();
			flwGameSettingsFPS = new FlowLayoutPanel();
			lblGameSettingsFPS = new Label();
			cmbGameSettingsFPS = new ComboBox();
			chkGameSettingsEnableVSync = new CheckBox();
			tbpAbout = new TabPage();
			txtAbout = new TextBox();
			tbcMainTab.SuspendLayout();
			tbpGachaTool.SuspendLayout();
			tbpGameSettings.SuspendLayout();
			flwGameSettingsButtons.SuspendLayout();
			flwGameSettingsLightQuality.SuspendLayout();
			flwGameSettingsAAMode.SuspendLayout();
			flwGameSettingsBloomQuality.SuspendLayout();
			flwGameSettingsSFXQuality.SuspendLayout();
			flwGameSettingsEnvDetailQuality.SuspendLayout();
			flwGameSettingsCharacterQuality.SuspendLayout();
			flwGameSettingsReflectionQuality.SuspendLayout();
			flwGameSettingsShadowQuality.SuspendLayout();
			flwGameSettingsPCResolution.SuspendLayout();
			flwGameSettingsRenderScale.SuspendLayout();
			flwGameSettingsFPS.SuspendLayout();
			tbpAbout.SuspendLayout();
			SuspendLayout();
			// 
			// tbcMainTab
			// 
			resources.ApplyResources(tbcMainTab, "tbcMainTab");
			tbcMainTab.Controls.Add(tbpGachaTool);
			tbcMainTab.Controls.Add(tbpGameSettings);
			tbcMainTab.Controls.Add(tbpAbout);
			tbcMainTab.Name = "tbcMainTab";
			tbcMainTab.SelectedIndex = 0;
			tbcMainTab.SelectedIndexChanged += tbcMainTab_SelectedIndexChanged;
			// 
			// tbpGachaTool
			// 
			tbpGachaTool.Controls.Add(btnGachaToolCopyGachaLink);
			tbpGachaTool.Controls.Add(lblGachaToolGachaLinkStatus);
			tbpGachaTool.Controls.Add(txtGachaToolGachaLink);
			tbpGachaTool.Controls.Add(btnGachaToolGetGachaLink);
			resources.ApplyResources(tbpGachaTool, "tbpGachaTool");
			tbpGachaTool.Name = "tbpGachaTool";
			tbpGachaTool.UseVisualStyleBackColor = true;
			// 
			// btnGachaToolCopyGachaLink
			// 
			resources.ApplyResources(btnGachaToolCopyGachaLink, "btnGachaToolCopyGachaLink");
			btnGachaToolCopyGachaLink.Name = "btnGachaToolCopyGachaLink";
			btnGachaToolCopyGachaLink.UseVisualStyleBackColor = true;
			btnGachaToolCopyGachaLink.Click += btnGachaToolCopyGachaLink_Click;
			// 
			// lblGachaToolGachaLinkStatus
			// 
			resources.ApplyResources(lblGachaToolGachaLinkStatus, "lblGachaToolGachaLinkStatus");
			lblGachaToolGachaLinkStatus.Name = "lblGachaToolGachaLinkStatus";
			// 
			// txtGachaToolGachaLink
			// 
			resources.ApplyResources(txtGachaToolGachaLink, "txtGachaToolGachaLink");
			txtGachaToolGachaLink.Name = "txtGachaToolGachaLink";
			txtGachaToolGachaLink.ReadOnly = true;
			// 
			// btnGachaToolGetGachaLink
			// 
			resources.ApplyResources(btnGachaToolGetGachaLink, "btnGachaToolGetGachaLink");
			btnGachaToolGetGachaLink.Name = "btnGachaToolGetGachaLink";
			btnGachaToolGetGachaLink.UseVisualStyleBackColor = true;
			btnGachaToolGetGachaLink.Click += btnGachaToolGetGachaLink_Click;
			// 
			// tbpGameSettings
			// 
			resources.ApplyResources(tbpGameSettings, "tbpGameSettings");
			tbpGameSettings.Controls.Add(flwGameSettingsButtons);
			tbpGameSettings.Controls.Add(flwGameSettingsLightQuality);
			tbpGameSettings.Controls.Add(flwGameSettingsAAMode);
			tbpGameSettings.Controls.Add(flwGameSettingsBloomQuality);
			tbpGameSettings.Controls.Add(flwGameSettingsSFXQuality);
			tbpGameSettings.Controls.Add(flwGameSettingsEnvDetailQuality);
			tbpGameSettings.Controls.Add(flwGameSettingsCharacterQuality);
			tbpGameSettings.Controls.Add(flwGameSettingsReflectionQuality);
			tbpGameSettings.Controls.Add(flwGameSettingsShadowQuality);
			tbpGameSettings.Controls.Add(flwGameSettingsPCResolution);
			tbpGameSettings.Controls.Add(flwGameSettingsRenderScale);
			tbpGameSettings.Controls.Add(flwGameSettingsFPS);
			tbpGameSettings.Controls.Add(chkGameSettingsEnableVSync);
			tbpGameSettings.Name = "tbpGameSettings";
			tbpGameSettings.UseVisualStyleBackColor = true;
			// 
			// flwGameSettingsButtons
			// 
			flwGameSettingsButtons.Controls.Add(btnGameSettingsSave);
			flwGameSettingsButtons.Controls.Add(btnGameSettingsReset);
			resources.ApplyResources(flwGameSettingsButtons, "flwGameSettingsButtons");
			flwGameSettingsButtons.Name = "flwGameSettingsButtons";
			// 
			// btnGameSettingsSave
			// 
			resources.ApplyResources(btnGameSettingsSave, "btnGameSettingsSave");
			btnGameSettingsSave.Name = "btnGameSettingsSave";
			btnGameSettingsSave.UseVisualStyleBackColor = true;
			btnGameSettingsSave.Click += btnGameSettingsSave_Click;
			// 
			// btnGameSettingsReset
			// 
			resources.ApplyResources(btnGameSettingsReset, "btnGameSettingsReset");
			btnGameSettingsReset.Name = "btnGameSettingsReset";
			btnGameSettingsReset.UseVisualStyleBackColor = true;
			btnGameSettingsReset.Click += btnGameSettingsReset_Click;
			// 
			// flwGameSettingsLightQuality
			// 
			flwGameSettingsLightQuality.Controls.Add(lblGameSettingsLightQuality);
			flwGameSettingsLightQuality.Controls.Add(cmbGameSettingsLightQuality);
			resources.ApplyResources(flwGameSettingsLightQuality, "flwGameSettingsLightQuality");
			flwGameSettingsLightQuality.Name = "flwGameSettingsLightQuality";
			// 
			// lblGameSettingsLightQuality
			// 
			resources.ApplyResources(lblGameSettingsLightQuality, "lblGameSettingsLightQuality");
			lblGameSettingsLightQuality.Name = "lblGameSettingsLightQuality";
			// 
			// cmbGameSettingsLightQuality
			// 
			cmbGameSettingsLightQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsLightQuality, "cmbGameSettingsLightQuality");
			cmbGameSettingsLightQuality.FormattingEnabled = true;
			cmbGameSettingsLightQuality.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsLightQuality.Items"), resources.GetString("cmbGameSettingsLightQuality.Items1"), resources.GetString("cmbGameSettingsLightQuality.Items2"), resources.GetString("cmbGameSettingsLightQuality.Items3"), resources.GetString("cmbGameSettingsLightQuality.Items4") });
			cmbGameSettingsLightQuality.Name = "cmbGameSettingsLightQuality";
			// 
			// flwGameSettingsAAMode
			// 
			flwGameSettingsAAMode.Controls.Add(lblGameSettingsAAMode);
			flwGameSettingsAAMode.Controls.Add(cmbGameSettingsAAMode);
			resources.ApplyResources(flwGameSettingsAAMode, "flwGameSettingsAAMode");
			flwGameSettingsAAMode.Name = "flwGameSettingsAAMode";
			// 
			// lblGameSettingsAAMode
			// 
			resources.ApplyResources(lblGameSettingsAAMode, "lblGameSettingsAAMode");
			lblGameSettingsAAMode.Name = "lblGameSettingsAAMode";
			// 
			// cmbGameSettingsAAMode
			// 
			cmbGameSettingsAAMode.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsAAMode, "cmbGameSettingsAAMode");
			cmbGameSettingsAAMode.FormattingEnabled = true;
			cmbGameSettingsAAMode.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsAAMode.Items"), resources.GetString("cmbGameSettingsAAMode.Items1"), resources.GetString("cmbGameSettingsAAMode.Items2") });
			cmbGameSettingsAAMode.Name = "cmbGameSettingsAAMode";
			// 
			// flwGameSettingsBloomQuality
			// 
			flwGameSettingsBloomQuality.Controls.Add(lblGameSettingsBloomQuality);
			flwGameSettingsBloomQuality.Controls.Add(cmbGameSettingsBloomQuality);
			resources.ApplyResources(flwGameSettingsBloomQuality, "flwGameSettingsBloomQuality");
			flwGameSettingsBloomQuality.Name = "flwGameSettingsBloomQuality";
			// 
			// lblGameSettingsBloomQuality
			// 
			resources.ApplyResources(lblGameSettingsBloomQuality, "lblGameSettingsBloomQuality");
			lblGameSettingsBloomQuality.Name = "lblGameSettingsBloomQuality";
			// 
			// cmbGameSettingsBloomQuality
			// 
			cmbGameSettingsBloomQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsBloomQuality, "cmbGameSettingsBloomQuality");
			cmbGameSettingsBloomQuality.FormattingEnabled = true;
			cmbGameSettingsBloomQuality.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsBloomQuality.Items"), resources.GetString("cmbGameSettingsBloomQuality.Items1"), resources.GetString("cmbGameSettingsBloomQuality.Items2"), resources.GetString("cmbGameSettingsBloomQuality.Items3"), resources.GetString("cmbGameSettingsBloomQuality.Items4"), resources.GetString("cmbGameSettingsBloomQuality.Items5") });
			cmbGameSettingsBloomQuality.Name = "cmbGameSettingsBloomQuality";
			// 
			// flwGameSettingsSFXQuality
			// 
			flwGameSettingsSFXQuality.Controls.Add(lblGameSettingsSFXQuality);
			flwGameSettingsSFXQuality.Controls.Add(cmbGameSettingsSFXQuality);
			resources.ApplyResources(flwGameSettingsSFXQuality, "flwGameSettingsSFXQuality");
			flwGameSettingsSFXQuality.Name = "flwGameSettingsSFXQuality";
			// 
			// lblGameSettingsSFXQuality
			// 
			resources.ApplyResources(lblGameSettingsSFXQuality, "lblGameSettingsSFXQuality");
			lblGameSettingsSFXQuality.Name = "lblGameSettingsSFXQuality";
			// 
			// cmbGameSettingsSFXQuality
			// 
			cmbGameSettingsSFXQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsSFXQuality, "cmbGameSettingsSFXQuality");
			cmbGameSettingsSFXQuality.FormattingEnabled = true;
			cmbGameSettingsSFXQuality.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsSFXQuality.Items"), resources.GetString("cmbGameSettingsSFXQuality.Items1"), resources.GetString("cmbGameSettingsSFXQuality.Items2"), resources.GetString("cmbGameSettingsSFXQuality.Items3") });
			cmbGameSettingsSFXQuality.Name = "cmbGameSettingsSFXQuality";
			// 
			// flwGameSettingsEnvDetailQuality
			// 
			flwGameSettingsEnvDetailQuality.Controls.Add(lblGameSettingsEnvDetailQuality);
			flwGameSettingsEnvDetailQuality.Controls.Add(cmbGameSettingsEnvDetailQuality);
			resources.ApplyResources(flwGameSettingsEnvDetailQuality, "flwGameSettingsEnvDetailQuality");
			flwGameSettingsEnvDetailQuality.Name = "flwGameSettingsEnvDetailQuality";
			// 
			// lblGameSettingsEnvDetailQuality
			// 
			resources.ApplyResources(lblGameSettingsEnvDetailQuality, "lblGameSettingsEnvDetailQuality");
			lblGameSettingsEnvDetailQuality.Name = "lblGameSettingsEnvDetailQuality";
			// 
			// cmbGameSettingsEnvDetailQuality
			// 
			cmbGameSettingsEnvDetailQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsEnvDetailQuality, "cmbGameSettingsEnvDetailQuality");
			cmbGameSettingsEnvDetailQuality.FormattingEnabled = true;
			cmbGameSettingsEnvDetailQuality.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsEnvDetailQuality.Items"), resources.GetString("cmbGameSettingsEnvDetailQuality.Items1"), resources.GetString("cmbGameSettingsEnvDetailQuality.Items2"), resources.GetString("cmbGameSettingsEnvDetailQuality.Items3"), resources.GetString("cmbGameSettingsEnvDetailQuality.Items4") });
			cmbGameSettingsEnvDetailQuality.Name = "cmbGameSettingsEnvDetailQuality";
			// 
			// flwGameSettingsCharacterQuality
			// 
			flwGameSettingsCharacterQuality.Controls.Add(lblGameSettingsCharacterQuality);
			flwGameSettingsCharacterQuality.Controls.Add(cmbGameSettingsCharacterQuality);
			resources.ApplyResources(flwGameSettingsCharacterQuality, "flwGameSettingsCharacterQuality");
			flwGameSettingsCharacterQuality.Name = "flwGameSettingsCharacterQuality";
			// 
			// lblGameSettingsCharacterQuality
			// 
			resources.ApplyResources(lblGameSettingsCharacterQuality, "lblGameSettingsCharacterQuality");
			lblGameSettingsCharacterQuality.Name = "lblGameSettingsCharacterQuality";
			// 
			// cmbGameSettingsCharacterQuality
			// 
			cmbGameSettingsCharacterQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsCharacterQuality, "cmbGameSettingsCharacterQuality");
			cmbGameSettingsCharacterQuality.FormattingEnabled = true;
			cmbGameSettingsCharacterQuality.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsCharacterQuality.Items"), resources.GetString("cmbGameSettingsCharacterQuality.Items1"), resources.GetString("cmbGameSettingsCharacterQuality.Items2") });
			cmbGameSettingsCharacterQuality.Name = "cmbGameSettingsCharacterQuality";
			// 
			// flwGameSettingsReflectionQuality
			// 
			flwGameSettingsReflectionQuality.Controls.Add(lblGameSettingsReflectionQuality);
			flwGameSettingsReflectionQuality.Controls.Add(cmbGameSettingsReflectionQuality);
			resources.ApplyResources(flwGameSettingsReflectionQuality, "flwGameSettingsReflectionQuality");
			flwGameSettingsReflectionQuality.Name = "flwGameSettingsReflectionQuality";
			// 
			// lblGameSettingsReflectionQuality
			// 
			resources.ApplyResources(lblGameSettingsReflectionQuality, "lblGameSettingsReflectionQuality");
			lblGameSettingsReflectionQuality.Name = "lblGameSettingsReflectionQuality";
			// 
			// cmbGameSettingsReflectionQuality
			// 
			cmbGameSettingsReflectionQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsReflectionQuality, "cmbGameSettingsReflectionQuality");
			cmbGameSettingsReflectionQuality.FormattingEnabled = true;
			cmbGameSettingsReflectionQuality.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsReflectionQuality.Items"), resources.GetString("cmbGameSettingsReflectionQuality.Items1"), resources.GetString("cmbGameSettingsReflectionQuality.Items2"), resources.GetString("cmbGameSettingsReflectionQuality.Items3"), resources.GetString("cmbGameSettingsReflectionQuality.Items4") });
			cmbGameSettingsReflectionQuality.Name = "cmbGameSettingsReflectionQuality";
			// 
			// flwGameSettingsShadowQuality
			// 
			flwGameSettingsShadowQuality.Controls.Add(lblGameSettingsShadowQuality);
			flwGameSettingsShadowQuality.Controls.Add(cmbGameSettingsShadowQuality);
			resources.ApplyResources(flwGameSettingsShadowQuality, "flwGameSettingsShadowQuality");
			flwGameSettingsShadowQuality.Name = "flwGameSettingsShadowQuality";
			// 
			// lblGameSettingsShadowQuality
			// 
			resources.ApplyResources(lblGameSettingsShadowQuality, "lblGameSettingsShadowQuality");
			lblGameSettingsShadowQuality.Name = "lblGameSettingsShadowQuality";
			// 
			// cmbGameSettingsShadowQuality
			// 
			cmbGameSettingsShadowQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsShadowQuality, "cmbGameSettingsShadowQuality");
			cmbGameSettingsShadowQuality.FormattingEnabled = true;
			cmbGameSettingsShadowQuality.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsShadowQuality.Items"), resources.GetString("cmbGameSettingsShadowQuality.Items1"), resources.GetString("cmbGameSettingsShadowQuality.Items2"), resources.GetString("cmbGameSettingsShadowQuality.Items3") });
			cmbGameSettingsShadowQuality.Name = "cmbGameSettingsShadowQuality";
			// 
			// flwGameSettingsPCResolution
			// 
			flwGameSettingsPCResolution.Controls.Add(lblGameSettingsHeight);
			flwGameSettingsPCResolution.Controls.Add(txtGameSettingsHeight);
			flwGameSettingsPCResolution.Controls.Add(lblGameSettingsWidth);
			flwGameSettingsPCResolution.Controls.Add(txtGameSettingsWidth);
			flwGameSettingsPCResolution.Controls.Add(chkGameSettingsFullScreen);
			resources.ApplyResources(flwGameSettingsPCResolution, "flwGameSettingsPCResolution");
			flwGameSettingsPCResolution.Name = "flwGameSettingsPCResolution";
			// 
			// lblGameSettingsHeight
			// 
			resources.ApplyResources(lblGameSettingsHeight, "lblGameSettingsHeight");
			lblGameSettingsHeight.Name = "lblGameSettingsHeight";
			// 
			// txtGameSettingsHeight
			// 
			resources.ApplyResources(txtGameSettingsHeight, "txtGameSettingsHeight");
			txtGameSettingsHeight.Name = "txtGameSettingsHeight";
			// 
			// lblGameSettingsWidth
			// 
			resources.ApplyResources(lblGameSettingsWidth, "lblGameSettingsWidth");
			lblGameSettingsWidth.Name = "lblGameSettingsWidth";
			// 
			// txtGameSettingsWidth
			// 
			resources.ApplyResources(txtGameSettingsWidth, "txtGameSettingsWidth");
			txtGameSettingsWidth.Name = "txtGameSettingsWidth";
			// 
			// chkGameSettingsFullScreen
			// 
			resources.ApplyResources(chkGameSettingsFullScreen, "chkGameSettingsFullScreen");
			chkGameSettingsFullScreen.Name = "chkGameSettingsFullScreen";
			chkGameSettingsFullScreen.UseVisualStyleBackColor = true;
			// 
			// flwGameSettingsRenderScale
			// 
			flwGameSettingsRenderScale.Controls.Add(lblGameSettingsRenderScale);
			flwGameSettingsRenderScale.Controls.Add(cmbGameSettingsRenderScale);
			resources.ApplyResources(flwGameSettingsRenderScale, "flwGameSettingsRenderScale");
			flwGameSettingsRenderScale.Name = "flwGameSettingsRenderScale";
			// 
			// lblGameSettingsRenderScale
			// 
			resources.ApplyResources(lblGameSettingsRenderScale, "lblGameSettingsRenderScale");
			lblGameSettingsRenderScale.Name = "lblGameSettingsRenderScale";
			// 
			// cmbGameSettingsRenderScale
			// 
			cmbGameSettingsRenderScale.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsRenderScale, "cmbGameSettingsRenderScale");
			cmbGameSettingsRenderScale.FormattingEnabled = true;
			cmbGameSettingsRenderScale.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsRenderScale.Items"), resources.GetString("cmbGameSettingsRenderScale.Items1"), resources.GetString("cmbGameSettingsRenderScale.Items2"), resources.GetString("cmbGameSettingsRenderScale.Items3"), resources.GetString("cmbGameSettingsRenderScale.Items4"), resources.GetString("cmbGameSettingsRenderScale.Items5"), resources.GetString("cmbGameSettingsRenderScale.Items6"), resources.GetString("cmbGameSettingsRenderScale.Items7") });
			cmbGameSettingsRenderScale.Name = "cmbGameSettingsRenderScale";
			// 
			// flwGameSettingsFPS
			// 
			flwGameSettingsFPS.Controls.Add(lblGameSettingsFPS);
			flwGameSettingsFPS.Controls.Add(cmbGameSettingsFPS);
			resources.ApplyResources(flwGameSettingsFPS, "flwGameSettingsFPS");
			flwGameSettingsFPS.Name = "flwGameSettingsFPS";
			// 
			// lblGameSettingsFPS
			// 
			resources.ApplyResources(lblGameSettingsFPS, "lblGameSettingsFPS");
			lblGameSettingsFPS.Name = "lblGameSettingsFPS";
			// 
			// cmbGameSettingsFPS
			// 
			cmbGameSettingsFPS.DropDownStyle = ComboBoxStyle.DropDownList;
			resources.ApplyResources(cmbGameSettingsFPS, "cmbGameSettingsFPS");
			cmbGameSettingsFPS.FormattingEnabled = true;
			cmbGameSettingsFPS.Items.AddRange(new object[] { resources.GetString("cmbGameSettingsFPS.Items"), resources.GetString("cmbGameSettingsFPS.Items1"), resources.GetString("cmbGameSettingsFPS.Items2") });
			cmbGameSettingsFPS.Name = "cmbGameSettingsFPS";
			// 
			// chkGameSettingsEnableVSync
			// 
			resources.ApplyResources(chkGameSettingsEnableVSync, "chkGameSettingsEnableVSync");
			chkGameSettingsEnableVSync.Name = "chkGameSettingsEnableVSync";
			chkGameSettingsEnableVSync.UseVisualStyleBackColor = true;
			// 
			// tbpAbout
			// 
			tbpAbout.Controls.Add(txtAbout);
			resources.ApplyResources(tbpAbout, "tbpAbout");
			tbpAbout.Name = "tbpAbout";
			tbpAbout.UseVisualStyleBackColor = true;
			// 
			// txtAbout
			// 
			resources.ApplyResources(txtAbout, "txtAbout");
			txtAbout.Name = "txtAbout";
			txtAbout.ReadOnly = true;
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tbcMainTab);
			Name = "MainForm";
			Load += MainForm_Load;
			tbcMainTab.ResumeLayout(false);
			tbpGachaTool.ResumeLayout(false);
			tbpGachaTool.PerformLayout();
			tbpGameSettings.ResumeLayout(false);
			tbpGameSettings.PerformLayout();
			flwGameSettingsButtons.ResumeLayout(false);
			flwGameSettingsLightQuality.ResumeLayout(false);
			flwGameSettingsLightQuality.PerformLayout();
			flwGameSettingsAAMode.ResumeLayout(false);
			flwGameSettingsAAMode.PerformLayout();
			flwGameSettingsBloomQuality.ResumeLayout(false);
			flwGameSettingsBloomQuality.PerformLayout();
			flwGameSettingsSFXQuality.ResumeLayout(false);
			flwGameSettingsSFXQuality.PerformLayout();
			flwGameSettingsEnvDetailQuality.ResumeLayout(false);
			flwGameSettingsEnvDetailQuality.PerformLayout();
			flwGameSettingsCharacterQuality.ResumeLayout(false);
			flwGameSettingsCharacterQuality.PerformLayout();
			flwGameSettingsReflectionQuality.ResumeLayout(false);
			flwGameSettingsReflectionQuality.PerformLayout();
			flwGameSettingsShadowQuality.ResumeLayout(false);
			flwGameSettingsShadowQuality.PerformLayout();
			flwGameSettingsPCResolution.ResumeLayout(false);
			flwGameSettingsPCResolution.PerformLayout();
			flwGameSettingsRenderScale.ResumeLayout(false);
			flwGameSettingsRenderScale.PerformLayout();
			flwGameSettingsFPS.ResumeLayout(false);
			flwGameSettingsFPS.PerformLayout();
			tbpAbout.ResumeLayout(false);
			tbpAbout.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tbcMainTab;
		private TabPage tbpGachaTool;
		private TabPage tbpGameSettings;
		private TabPage tbpAbout;
		private Label lblGameSettingsFPS;
		private ComboBox cmbGameSettingsFPS;
		private CheckBox chkGameSettingsEnableVSync;
		private FlowLayoutPanel flwGameSettingsFPS;
		private FlowLayoutPanel flwGameSettingsRenderScale;
		private Label lblGameSettingsRenderScale;
		private ComboBox cmbGameSettingsRenderScale;
		private FlowLayoutPanel flwGameSettingsPCResolution;
		private Label lblGameSettingsHeight;
		private TextBox txtGameSettingsHeight;
		private Label lblGameSettingsWidth;
		private TextBox txtGameSettingsWidth;
		private CheckBox chkGameSettingsFullScreen;
		private FlowLayoutPanel flwGameSettingsShadowQuality;
		private Label lblGameSettingsShadowQuality;
		private ComboBox cmbGameSettingsShadowQuality;
		private FlowLayoutPanel flwGameSettingsReflectionQuality;
		private Label lblGameSettingsReflectionQuality;
		private ComboBox cmbGameSettingsReflectionQuality;
		private FlowLayoutPanel flwGameSettingsCharacterQuality;
		private Label lblGameSettingsCharacterQuality;
		private ComboBox cmbGameSettingsCharacterQuality;
		private FlowLayoutPanel flwGameSettingsEnvDetailQuality;
		private Label lblGameSettingsEnvDetailQuality;
		private ComboBox cmbGameSettingsEnvDetailQuality;
		private FlowLayoutPanel flwGameSettingsSFXQuality;
		private Label lblGameSettingsSFXQuality;
		private ComboBox cmbGameSettingsSFXQuality;
		private FlowLayoutPanel flwGameSettingsBloomQuality;
		private Label lblGameSettingsBloomQuality;
		private ComboBox cmbGameSettingsBloomQuality;
		private FlowLayoutPanel flwGameSettingsAAMode;
		private Label lblGameSettingsAAMode;
		private ComboBox cmbGameSettingsAAMode;
		private FlowLayoutPanel flwGameSettingsLightQuality;
		private Label lblGameSettingsLightQuality;
		private ComboBox cmbGameSettingsLightQuality;
		private Button btnGameSettingsSave;
		private Button btnGameSettingsReset;
		private FlowLayoutPanel flwGameSettingsButtons;
		private TextBox txtAbout;
		private Button btnGachaToolGetGachaLink;
		private TextBox txtGachaToolGachaLink;
		private Label lblGachaToolGachaLinkStatus;
		private Button btnGachaToolCopyGachaLink;
	}
}