namespace ClipboardMonitorLite
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.groupBox_General = new System.Windows.Forms.GroupBox();
            this.groupBox_Update = new System.Windows.Forms.GroupBox();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_checkForUpdates = new System.Windows.Forms.Button();
            this.check_UpdateOnStartup = new System.Windows.Forms.CheckBox();
            this.txt_updateInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox_SaveSettings = new System.Windows.Forms.GroupBox();
            this.label_WriteRealTimeInfo = new System.Windows.Forms.Label();
            this.check_writeInRealTime = new System.Windows.Forms.CheckBox();
            this.radio_replace = new System.Windows.Forms.RadioButton();
            this.radio_append = new System.Windows.Forms.RadioButton();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label_FileLocation = new System.Windows.Forms.Label();
            this.txt_FileLocation = new System.Windows.Forms.TextBox();
            this.groupBox_Behaviour = new System.Windows.Forms.GroupBox();
            this.combo_lang = new System.Windows.Forms.ComboBox();
            this.label_Lang = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.check_HideDonate = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radio_ExitOnClose = new System.Windows.Forms.RadioButton();
            this.radio_MinimizeOnClose = new System.Windows.Forms.RadioButton();
            this.label_WhenMainWinClosed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.check_StartMinimized = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.check_openWithWindows = new System.Windows.Forms.CheckBox();
            this.combo_timeFormat = new System.Windows.Forms.ComboBox();
            this.numeric_clearAfter = new System.Windows.Forms.NumericUpDown();
            this.label_every = new System.Windows.Forms.Label();
            this.check_AutoClearHistory = new System.Windows.Forms.CheckBox();
            this.label_ShowNotificationFor = new System.Windows.Forms.Label();
            this.numeric_notifTimeout = new System.Windows.Forms.NumericUpDown();
            this.check_SaveToFile = new System.Windows.Forms.CheckBox();
            this.check_NotifyOfCopy = new System.Windows.Forms.CheckBox();
            this.check_UseWhiteIcon = new System.Windows.Forms.CheckBox();
            this.label_NoAdmin = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label_version = new System.Windows.Forms.Label();
            this.groupBox_General.SuspendLayout();
            this.groupBox_Update.SuspendLayout();
            this.groupBox_SaveSettings.SuspendLayout();
            this.groupBox_Behaviour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clearAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_notifTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_General
            // 
            this.groupBox_General.Controls.Add(this.groupBox_Update);
            this.groupBox_General.Controls.Add(this.groupBox_SaveSettings);
            this.groupBox_General.Controls.Add(this.groupBox_Behaviour);
            this.groupBox_General.Location = new System.Drawing.Point(12, 12);
            this.groupBox_General.Name = "groupBox_General";
            this.groupBox_General.Size = new System.Drawing.Size(720, 561);
            this.groupBox_General.TabIndex = 0;
            this.groupBox_General.TabStop = false;
            this.groupBox_General.Text = "General";
            // 
            // groupBox_Update
            // 
            this.groupBox_Update.Controls.Add(this.btn_about);
            this.groupBox_Update.Controls.Add(this.btn_checkForUpdates);
            this.groupBox_Update.Controls.Add(this.check_UpdateOnStartup);
            this.groupBox_Update.Controls.Add(this.txt_updateInfo);
            this.groupBox_Update.Location = new System.Drawing.Point(362, 245);
            this.groupBox_Update.Name = "groupBox_Update";
            this.groupBox_Update.Size = new System.Drawing.Size(350, 256);
            this.groupBox_Update.TabIndex = 2;
            this.groupBox_Update.TabStop = false;
            this.groupBox_Update.Text = "Update and current version";
            // 
            // btn_about
            // 
            this.btn_about.Enabled = false;
            this.btn_about.Location = new System.Drawing.Point(214, 148);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(130, 50);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            // 
            // btn_checkForUpdates
            // 
            this.btn_checkForUpdates.Location = new System.Drawing.Point(6, 148);
            this.btn_checkForUpdates.Name = "btn_checkForUpdates";
            this.btn_checkForUpdates.Size = new System.Drawing.Size(130, 50);
            this.btn_checkForUpdates.TabIndex = 2;
            this.btn_checkForUpdates.Text = "Check for updates";
            this.btn_checkForUpdates.UseVisualStyleBackColor = true;
            // 
            // check_UpdateOnStartup
            // 
            this.check_UpdateOnStartup.AutoSize = true;
            this.check_UpdateOnStartup.Location = new System.Drawing.Point(10, 213);
            this.check_UpdateOnStartup.Name = "check_UpdateOnStartup";
            this.check_UpdateOnStartup.Size = new System.Drawing.Size(241, 24);
            this.check_UpdateOnStartup.TabIndex = 1;
            this.check_UpdateOnStartup.Text = "Check for updates on startup";
            this.check_UpdateOnStartup.UseVisualStyleBackColor = true;
            // 
            // txt_updateInfo
            // 
            this.txt_updateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_updateInfo.Location = new System.Drawing.Point(6, 28);
            this.txt_updateInfo.Name = "txt_updateInfo";
            this.txt_updateInfo.ReadOnly = true;
            this.txt_updateInfo.Size = new System.Drawing.Size(338, 114);
            this.txt_updateInfo.TabIndex = 0;
            this.txt_updateInfo.Text = "";
            // 
            // groupBox_SaveSettings
            // 
            this.groupBox_SaveSettings.Controls.Add(this.label_WriteRealTimeInfo);
            this.groupBox_SaveSettings.Controls.Add(this.check_writeInRealTime);
            this.groupBox_SaveSettings.Controls.Add(this.radio_replace);
            this.groupBox_SaveSettings.Controls.Add(this.radio_append);
            this.groupBox_SaveSettings.Controls.Add(this.btn_browse);
            this.groupBox_SaveSettings.Controls.Add(this.label_FileLocation);
            this.groupBox_SaveSettings.Controls.Add(this.txt_FileLocation);
            this.groupBox_SaveSettings.Location = new System.Drawing.Point(362, 25);
            this.groupBox_SaveSettings.Name = "groupBox_SaveSettings";
            this.groupBox_SaveSettings.Size = new System.Drawing.Size(350, 217);
            this.groupBox_SaveSettings.TabIndex = 1;
            this.groupBox_SaveSettings.TabStop = false;
            this.groupBox_SaveSettings.Text = "Save to file settings";
            // 
            // label_WriteRealTimeInfo
            // 
            this.label_WriteRealTimeInfo.AutoSize = true;
            this.label_WriteRealTimeInfo.Location = new System.Drawing.Point(33, 147);
            this.label_WriteRealTimeInfo.Name = "label_WriteRealTimeInfo";
            this.label_WriteRealTimeInfo.Size = new System.Drawing.Size(81, 20);
            this.label_WriteRealTimeInfo.TabIndex = 6;
            this.label_WriteRealTimeInfo.Text = "labExplain\r\n";
            // 
            // check_writeInRealTime
            // 
            this.check_writeInRealTime.AutoSize = true;
            this.check_writeInRealTime.Enabled = false;
            this.check_writeInRealTime.Location = new System.Drawing.Point(6, 114);
            this.check_writeInRealTime.Name = "check_writeInRealTime";
            this.check_writeInRealTime.Size = new System.Drawing.Size(176, 24);
            this.check_writeInRealTime.TabIndex = 5;
            this.check_writeInRealTime.Text = "Write file in real time";
            this.check_writeInRealTime.UseVisualStyleBackColor = true;
            // 
            // radio_replace
            // 
            this.radio_replace.AutoSize = true;
            this.radio_replace.Checked = true;
            this.radio_replace.Enabled = false;
            this.radio_replace.Location = new System.Drawing.Point(134, 83);
            this.radio_replace.Name = "radio_replace";
            this.radio_replace.Size = new System.Drawing.Size(190, 24);
            this.radio_replace.TabIndex = 4;
            this.radio_replace.TabStop = true;
            this.radio_replace.Text = "Empty file and replace";
            this.radio_replace.UseVisualStyleBackColor = true;
            // 
            // radio_append
            // 
            this.radio_append.AutoSize = true;
            this.radio_append.Enabled = false;
            this.radio_append.Location = new System.Drawing.Point(6, 83);
            this.radio_append.Name = "radio_append";
            this.radio_append.Size = new System.Drawing.Size(114, 24);
            this.radio_append.TabIndex = 3;
            this.radio_append.Text = "Append file";
            this.radio_append.UseVisualStyleBackColor = true;
            // 
            // btn_browse
            // 
            this.btn_browse.Enabled = false;
            this.btn_browse.Location = new System.Drawing.Point(266, 48);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(78, 26);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.Btn_browse_Click);
            // 
            // label_FileLocation
            // 
            this.label_FileLocation.AutoSize = true;
            this.label_FileLocation.Location = new System.Drawing.Point(6, 25);
            this.label_FileLocation.Name = "label_FileLocation";
            this.label_FileLocation.Size = new System.Drawing.Size(93, 20);
            this.label_FileLocation.TabIndex = 1;
            this.label_FileLocation.Text = "File location";
            // 
            // txt_FileLocation
            // 
            this.txt_FileLocation.Enabled = false;
            this.txt_FileLocation.Location = new System.Drawing.Point(6, 48);
            this.txt_FileLocation.Name = "txt_FileLocation";
            this.txt_FileLocation.Size = new System.Drawing.Size(254, 26);
            this.txt_FileLocation.TabIndex = 0;
            // 
            // groupBox_Behaviour
            // 
            this.groupBox_Behaviour.Controls.Add(this.combo_lang);
            this.groupBox_Behaviour.Controls.Add(this.label_Lang);
            this.groupBox_Behaviour.Controls.Add(this.label13);
            this.groupBox_Behaviour.Controls.Add(this.check_HideDonate);
            this.groupBox_Behaviour.Controls.Add(this.label12);
            this.groupBox_Behaviour.Controls.Add(this.radio_ExitOnClose);
            this.groupBox_Behaviour.Controls.Add(this.radio_MinimizeOnClose);
            this.groupBox_Behaviour.Controls.Add(this.label_WhenMainWinClosed);
            this.groupBox_Behaviour.Controls.Add(this.label10);
            this.groupBox_Behaviour.Controls.Add(this.check_StartMinimized);
            this.groupBox_Behaviour.Controls.Add(this.label9);
            this.groupBox_Behaviour.Controls.Add(this.label6);
            this.groupBox_Behaviour.Controls.Add(this.label5);
            this.groupBox_Behaviour.Controls.Add(this.label4);
            this.groupBox_Behaviour.Controls.Add(this.label3);
            this.groupBox_Behaviour.Controls.Add(this.check_openWithWindows);
            this.groupBox_Behaviour.Controls.Add(this.combo_timeFormat);
            this.groupBox_Behaviour.Controls.Add(this.numeric_clearAfter);
            this.groupBox_Behaviour.Controls.Add(this.label_every);
            this.groupBox_Behaviour.Controls.Add(this.check_AutoClearHistory);
            this.groupBox_Behaviour.Controls.Add(this.label_ShowNotificationFor);
            this.groupBox_Behaviour.Controls.Add(this.numeric_notifTimeout);
            this.groupBox_Behaviour.Controls.Add(this.check_SaveToFile);
            this.groupBox_Behaviour.Controls.Add(this.check_NotifyOfCopy);
            this.groupBox_Behaviour.Controls.Add(this.check_UseWhiteIcon);
            this.groupBox_Behaviour.Location = new System.Drawing.Point(6, 25);
            this.groupBox_Behaviour.Name = "groupBox_Behaviour";
            this.groupBox_Behaviour.Size = new System.Drawing.Size(350, 530);
            this.groupBox_Behaviour.TabIndex = 1;
            this.groupBox_Behaviour.TabStop = false;
            this.groupBox_Behaviour.Text = "Behaviour and visuals";
            // 
            // combo_lang
            // 
            this.combo_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_lang.FormattingEnabled = true;
            this.combo_lang.Items.AddRange(new object[] {
            "en",
            "hu",
            "no"});
            this.combo_lang.Location = new System.Drawing.Point(103, 413);
            this.combo_lang.Name = "combo_lang";
            this.combo_lang.Size = new System.Drawing.Size(116, 28);
            this.combo_lang.TabIndex = 23;
            this.combo_lang.SelectedIndexChanged += new System.EventHandler(this.Combo_lang_SelectedIndexChanged);
            // 
            // label_Lang
            // 
            this.label_Lang.AutoSize = true;
            this.label_Lang.Location = new System.Drawing.Point(2, 416);
            this.label_Lang.Name = "label_Lang";
            this.label_Lang.Size = new System.Drawing.Size(60, 20);
            this.label_Lang.TabIndex = 22;
            this.label_Lang.Text = "label14";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(0, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(350, 2);
            this.label13.TabIndex = 21;
            // 
            // check_HideDonate
            // 
            this.check_HideDonate.AutoSize = true;
            this.check_HideDonate.Checked = true;
            this.check_HideDonate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_HideDonate.Location = new System.Drawing.Point(6, 370);
            this.check_HideDonate.Name = "check_HideDonate";
            this.check_HideDonate.Size = new System.Drawing.Size(307, 24);
            this.check_HideDonate.TabIndex = 20;
            this.check_HideDonate.Text = "Show donation button on main window";
            this.check_HideDonate.UseVisualStyleBackColor = true;
            this.check_HideDonate.CheckedChanged += new System.EventHandler(this.Check_HideDonate_CheckedChanged);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(350, 2);
            this.label12.TabIndex = 19;
            // 
            // radio_ExitOnClose
            // 
            this.radio_ExitOnClose.AutoSize = true;
            this.radio_ExitOnClose.Checked = true;
            this.radio_ExitOnClose.Location = new System.Drawing.Point(6, 333);
            this.radio_ExitOnClose.Name = "radio_ExitOnClose";
            this.radio_ExitOnClose.Size = new System.Drawing.Size(167, 24);
            this.radio_ExitOnClose.TabIndex = 18;
            this.radio_ExitOnClose.TabStop = true;
            this.radio_ExitOnClose.Text = "Exit the application";
            this.radio_ExitOnClose.UseVisualStyleBackColor = true;
            // 
            // radio_MinimizeOnClose
            // 
            this.radio_MinimizeOnClose.AutoSize = true;
            this.radio_MinimizeOnClose.Location = new System.Drawing.Point(6, 305);
            this.radio_MinimizeOnClose.Name = "radio_MinimizeOnClose";
            this.radio_MinimizeOnClose.Size = new System.Drawing.Size(201, 24);
            this.radio_MinimizeOnClose.TabIndex = 17;
            this.radio_MinimizeOnClose.Text = "Minimize on system tray";
            this.radio_MinimizeOnClose.UseVisualStyleBackColor = true;
            this.radio_MinimizeOnClose.CheckedChanged += new System.EventHandler(this.Radio_MinimizeOnClose_CheckedChanged);
            // 
            // label_WhenMainWinClosed
            // 
            this.label_WhenMainWinClosed.AutoSize = true;
            this.label_WhenMainWinClosed.Location = new System.Drawing.Point(6, 282);
            this.label_WhenMainWinClosed.Name = "label_WhenMainWinClosed";
            this.label_WhenMainWinClosed.Size = new System.Drawing.Size(230, 20);
            this.label_WhenMainWinClosed.TabIndex = 16;
            this.label_WhenMainWinClosed.Text = "When I close the main Window:";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(0, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(350, 2);
            this.label10.TabIndex = 15;
            // 
            // check_StartMinimized
            // 
            this.check_StartMinimized.AutoSize = true;
            this.check_StartMinimized.Location = new System.Drawing.Point(6, 250);
            this.check_StartMinimized.Name = "check_StartMinimized";
            this.check_StartMinimized.Size = new System.Drawing.Size(144, 24);
            this.check_StartMinimized.TabIndex = 14;
            this.check_StartMinimized.Text = "Start Minimized";
            this.check_StartMinimized.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(355, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 2);
            this.label9.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(0, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 2);
            this.label6.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(0, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 2);
            this.label5.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(0, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 2);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 2);
            this.label3.TabIndex = 2;
            // 
            // check_openWithWindows
            // 
            this.check_openWithWindows.AutoSize = true;
            this.check_openWithWindows.Location = new System.Drawing.Point(6, 220);
            this.check_openWithWindows.Name = "check_openWithWindows";
            this.check_openWithWindows.Size = new System.Drawing.Size(228, 24);
            this.check_openWithWindows.TabIndex = 9;
            this.check_openWithWindows.Text = "Open when Windows starts";
            this.check_openWithWindows.UseVisualStyleBackColor = true;
            // 
            // combo_timeFormat
            // 
            this.combo_timeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_timeFormat.Enabled = false;
            this.combo_timeFormat.FormattingEnabled = true;
            this.combo_timeFormat.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.combo_timeFormat.Location = new System.Drawing.Point(205, 185);
            this.combo_timeFormat.Name = "combo_timeFormat";
            this.combo_timeFormat.Size = new System.Drawing.Size(125, 28);
            this.combo_timeFormat.TabIndex = 8;
            this.combo_timeFormat.SelectedIndexChanged += new System.EventHandler(this.Combo_timeFormat_SelectedIndexChanged);
            // 
            // numeric_clearAfter
            // 
            this.numeric_clearAfter.Enabled = false;
            this.numeric_clearAfter.Location = new System.Drawing.Point(79, 185);
            this.numeric_clearAfter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_clearAfter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_clearAfter.Name = "numeric_clearAfter";
            this.numeric_clearAfter.Size = new System.Drawing.Size(120, 26);
            this.numeric_clearAfter.TabIndex = 7;
            this.numeric_clearAfter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_every
            // 
            this.label_every.AutoSize = true;
            this.label_every.Location = new System.Drawing.Point(25, 187);
            this.label_every.Name = "label_every";
            this.label_every.Size = new System.Drawing.Size(48, 20);
            this.label_every.TabIndex = 6;
            this.label_every.Text = "Every";
            // 
            // check_AutoClearHistory
            // 
            this.check_AutoClearHistory.AutoSize = true;
            this.check_AutoClearHistory.Location = new System.Drawing.Point(6, 160);
            this.check_AutoClearHistory.Name = "check_AutoClearHistory";
            this.check_AutoClearHistory.Size = new System.Drawing.Size(309, 24);
            this.check_AutoClearHistory.TabIndex = 5;
            this.check_AutoClearHistory.Text = "Automatically clear my clipboard history";
            this.check_AutoClearHistory.UseVisualStyleBackColor = true;
            // 
            // label_ShowNotificationFor
            // 
            this.label_ShowNotificationFor.AutoSize = true;
            this.label_ShowNotificationFor.Location = new System.Drawing.Point(25, 87);
            this.label_ShowNotificationFor.Name = "label_ShowNotificationFor";
            this.label_ShowNotificationFor.Size = new System.Drawing.Size(231, 20);
            this.label_ShowNotificationFor.TabIndex = 4;
            this.label_ShowNotificationFor.Text = "Show notification for: (seconds)";
            // 
            // numeric_notifTimeout
            // 
            this.numeric_notifTimeout.Location = new System.Drawing.Point(260, 85);
            this.numeric_notifTimeout.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeric_notifTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_notifTimeout.Name = "numeric_notifTimeout";
            this.numeric_notifTimeout.Size = new System.Drawing.Size(70, 26);
            this.numeric_notifTimeout.TabIndex = 3;
            this.numeric_notifTimeout.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // check_SaveToFile
            // 
            this.check_SaveToFile.AutoSize = true;
            this.check_SaveToFile.Location = new System.Drawing.Point(6, 125);
            this.check_SaveToFile.Name = "check_SaveToFile";
            this.check_SaveToFile.Size = new System.Drawing.Size(337, 24);
            this.check_SaveToFile.TabIndex = 2;
            this.check_SaveToFile.Text = "Save the clipboard history to a local text file";
            this.check_SaveToFile.UseVisualStyleBackColor = true;
            // 
            // check_NotifyOfCopy
            // 
            this.check_NotifyOfCopy.AutoSize = true;
            this.check_NotifyOfCopy.Location = new System.Drawing.Point(6, 55);
            this.check_NotifyOfCopy.Name = "check_NotifyOfCopy";
            this.check_NotifyOfCopy.Size = new System.Drawing.Size(300, 24);
            this.check_NotifyOfCopy.TabIndex = 1;
            this.check_NotifyOfCopy.Text = "Notify me when my clipboard changes";
            this.check_NotifyOfCopy.UseVisualStyleBackColor = true;
            // 
            // check_UseWhiteIcon
            // 
            this.check_UseWhiteIcon.AutoSize = true;
            this.check_UseWhiteIcon.Location = new System.Drawing.Point(6, 25);
            this.check_UseWhiteIcon.Name = "check_UseWhiteIcon";
            this.check_UseWhiteIcon.Size = new System.Drawing.Size(265, 24);
            this.check_UseWhiteIcon.TabIndex = 0;
            this.check_UseWhiteIcon.Text = "Use white icon in the system tray";
            this.check_UseWhiteIcon.UseVisualStyleBackColor = true;
            // 
            // label_NoAdmin
            // 
            this.label_NoAdmin.AutoSize = true;
            this.label_NoAdmin.Location = new System.Drawing.Point(93, 576);
            this.label_NoAdmin.Name = "label_NoAdmin";
            this.label_NoAdmin.Size = new System.Drawing.Size(303, 60);
            this.label_NoAdmin.TabIndex = 5;
            this.label_NoAdmin.Text = "Sorry! You don\'t have admin rights, or the\r\napplication failed to launch as one, " +
    "please\r\ntry to run the app as administrator!";
            this.label_NoAdmin.Visible = false;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(492, 579);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(117, 53);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(615, 579);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 53);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Location = new System.Drawing.Point(14, 612);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(60, 20);
            this.label_version.TabIndex = 5;
            this.label_version.Text = "label13";
            // 
            // OptionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(748, 644);
            this.ControlBox = false;
            this.Controls.Add(this.label_NoAdmin);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox_General);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.groupBox_General.ResumeLayout(false);
            this.groupBox_Update.ResumeLayout(false);
            this.groupBox_Update.PerformLayout();
            this.groupBox_SaveSettings.ResumeLayout(false);
            this.groupBox_SaveSettings.PerformLayout();
            this.groupBox_Behaviour.ResumeLayout(false);
            this.groupBox_Behaviour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clearAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_notifTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_General;
        private System.Windows.Forms.GroupBox groupBox_SaveSettings;
        private System.Windows.Forms.GroupBox groupBox_Behaviour;
        private System.Windows.Forms.Label label_ShowNotificationFor;
        private System.Windows.Forms.NumericUpDown numeric_notifTimeout;
        private System.Windows.Forms.CheckBox check_SaveToFile;
        private System.Windows.Forms.CheckBox check_NotifyOfCopy;
        private System.Windows.Forms.CheckBox check_UseWhiteIcon;
        private System.Windows.Forms.ComboBox combo_timeFormat;
        private System.Windows.Forms.NumericUpDown numeric_clearAfter;
        private System.Windows.Forms.Label label_every;
        private System.Windows.Forms.CheckBox check_AutoClearHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_openWithWindows;
        private System.Windows.Forms.RadioButton radio_replace;
        private System.Windows.Forms.RadioButton radio_append;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label_FileLocation;
        private System.Windows.Forms.TextBox txt_FileLocation;
        private System.Windows.Forms.Label label_WriteRealTimeInfo;
        private System.Windows.Forms.CheckBox check_writeInRealTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label_NoAdmin;
        private System.Windows.Forms.CheckBox check_StartMinimized;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radio_ExitOnClose;
        private System.Windows.Forms.RadioButton radio_MinimizeOnClose;
        private System.Windows.Forms.Label label_WhenMainWinClosed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox check_HideDonate;
        private System.Windows.Forms.GroupBox groupBox_Update;
        private System.Windows.Forms.RichTextBox txt_updateInfo;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_checkForUpdates;
        private System.Windows.Forms.CheckBox check_UpdateOnStartup;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combo_lang;
        private System.Windows.Forms.Label label_Lang;
    }
}