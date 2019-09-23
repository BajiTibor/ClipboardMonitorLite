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
            this.GroupBox_General = new System.Windows.Forms.GroupBox();
            this.GroupBox_OnlineSettings = new System.Windows.Forms.GroupBox();
            this.GroupBox_TimeBeforeReconnect = new System.Windows.Forms.GroupBox();
            this.Label_Seconds = new System.Windows.Forms.Label();
            this.numeric_ReconnectDelay = new System.Windows.Forms.NumericUpDown();
            this.Check_IncludeDeviceName = new System.Windows.Forms.CheckBox();
            this.GroupBox_OnlineBehaviour = new System.Windows.Forms.GroupBox();
            this.Check_LimitTraffic = new System.Windows.Forms.CheckBox();
            this.Label_OnlineBehaviourExplanation = new System.Windows.Forms.Label();
            this.Radio_ReceiveOnly = new System.Windows.Forms.RadioButton();
            this.Radio_SendOnly = new System.Windows.Forms.RadioButton();
            this.GroupBox_SaveToFileSettings = new System.Windows.Forms.GroupBox();
            this.Label_WriteRealTimeInfo = new System.Windows.Forms.Label();
            this.Check_WriteInRealTime = new System.Windows.Forms.CheckBox();
            this.Btn_Browse = new System.Windows.Forms.Button();
            this.Label_FileLocation = new System.Windows.Forms.Label();
            this.txt_FileLocation = new System.Windows.Forms.TextBox();
            this.GroupBox_BehaviourAndVisuals = new System.Windows.Forms.GroupBox();
            this.Check_UseTimestamp = new System.Windows.Forms.CheckBox();
            this.Check_OpenWithWin = new System.Windows.Forms.CheckBox();
            this.Label_Minutes = new System.Windows.Forms.Label();
            this.Check_OnlineMode = new System.Windows.Forms.CheckBox();
            this.combo_lang = new System.Windows.Forms.ComboBox();
            this.Label_Lang = new System.Windows.Forms.Label();
            this.DONOTMODIFY7 = new System.Windows.Forms.Label();
            this.Check_ShowDonation = new System.Windows.Forms.CheckBox();
            this.DONOTMODIFY6 = new System.Windows.Forms.Label();
            this.Radio_ExitApp = new System.Windows.Forms.RadioButton();
            this.Radio_Minimize = new System.Windows.Forms.RadioButton();
            this.Label_WhenMainWindowClosed = new System.Windows.Forms.Label();
            this.DONOTMODIFY5 = new System.Windows.Forms.Label();
            this.Check_StartMinimized = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DONOTMODIFY4 = new System.Windows.Forms.Label();
            this.DONOTMODIFY3 = new System.Windows.Forms.Label();
            this.DONOTMODIFY2 = new System.Windows.Forms.Label();
            this.DONOTMODIFY1 = new System.Windows.Forms.Label();
            this.numeric_clearAfter = new System.Windows.Forms.NumericUpDown();
            this.Label_Every = new System.Windows.Forms.Label();
            this.Check_AutoClearClipboard = new System.Windows.Forms.CheckBox();
            this.Check_SaveToFile = new System.Windows.Forms.CheckBox();
            this.Check_NotifyOfCopy = new System.Windows.Forms.CheckBox();
            this.Check_UseWhiteIcon = new System.Windows.Forms.CheckBox();
            this.Btn_Apply = new System.Windows.Forms.Button();
            this.Label_Version = new System.Windows.Forms.Label();
            this.Group_GroupSettings = new System.Windows.Forms.GroupBox();
            this.Label_GroupId = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.txt_GroupId = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.Btn_ShowPassword = new System.Windows.Forms.Button();
            this.GroupBox_General.SuspendLayout();
            this.GroupBox_OnlineSettings.SuspendLayout();
            this.GroupBox_TimeBeforeReconnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ReconnectDelay)).BeginInit();
            this.GroupBox_OnlineBehaviour.SuspendLayout();
            this.GroupBox_SaveToFileSettings.SuspendLayout();
            this.GroupBox_BehaviourAndVisuals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clearAfter)).BeginInit();
            this.Group_GroupSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_General
            // 
            this.GroupBox_General.Controls.Add(this.GroupBox_OnlineSettings);
            this.GroupBox_General.Controls.Add(this.GroupBox_SaveToFileSettings);
            this.GroupBox_General.Controls.Add(this.GroupBox_BehaviourAndVisuals);
            this.GroupBox_General.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_General.Name = "GroupBox_General";
            this.GroupBox_General.Size = new System.Drawing.Size(720, 668);
            this.GroupBox_General.TabIndex = 0;
            this.GroupBox_General.TabStop = false;
            this.GroupBox_General.Text = "General";
            // 
            // GroupBox_OnlineSettings
            // 
            this.GroupBox_OnlineSettings.Controls.Add(this.Group_GroupSettings);
            this.GroupBox_OnlineSettings.Controls.Add(this.GroupBox_TimeBeforeReconnect);
            this.GroupBox_OnlineSettings.Controls.Add(this.Check_IncludeDeviceName);
            this.GroupBox_OnlineSettings.Controls.Add(this.GroupBox_OnlineBehaviour);
            this.GroupBox_OnlineSettings.Location = new System.Drawing.Point(362, 220);
            this.GroupBox_OnlineSettings.Name = "GroupBox_OnlineSettings";
            this.GroupBox_OnlineSettings.Size = new System.Drawing.Size(349, 442);
            this.GroupBox_OnlineSettings.TabIndex = 0;
            this.GroupBox_OnlineSettings.TabStop = false;
            this.GroupBox_OnlineSettings.Text = "Online Settings";
            // 
            // GroupBox_TimeBeforeReconnect
            // 
            this.GroupBox_TimeBeforeReconnect.Controls.Add(this.Label_Seconds);
            this.GroupBox_TimeBeforeReconnect.Controls.Add(this.numeric_ReconnectDelay);
            this.GroupBox_TimeBeforeReconnect.Location = new System.Drawing.Point(6, 25);
            this.GroupBox_TimeBeforeReconnect.Name = "GroupBox_TimeBeforeReconnect";
            this.GroupBox_TimeBeforeReconnect.Size = new System.Drawing.Size(337, 69);
            this.GroupBox_TimeBeforeReconnect.TabIndex = 0;
            this.GroupBox_TimeBeforeReconnect.TabStop = false;
            this.GroupBox_TimeBeforeReconnect.Text = "Delay before trying to reconnect";
            // 
            // Label_Seconds
            // 
            this.Label_Seconds.AutoSize = true;
            this.Label_Seconds.Location = new System.Drawing.Point(6, 37);
            this.Label_Seconds.Name = "Label_Seconds";
            this.Label_Seconds.Size = new System.Drawing.Size(49, 13);
            this.Label_Seconds.TabIndex = 1;
            this.Label_Seconds.Text = "Seconds";
            // 
            // numeric_ReconnectDelay
            // 
            this.numeric_ReconnectDelay.Location = new System.Drawing.Point(84, 35);
            this.numeric_ReconnectDelay.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numeric_ReconnectDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_ReconnectDelay.Name = "numeric_ReconnectDelay";
            this.numeric_ReconnectDelay.Size = new System.Drawing.Size(112, 20);
            this.numeric_ReconnectDelay.TabIndex = 17;
            this.numeric_ReconnectDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Check_IncludeDeviceName
            // 
            this.Check_IncludeDeviceName.AutoSize = true;
            this.Check_IncludeDeviceName.Location = new System.Drawing.Point(12, 419);
            this.Check_IncludeDeviceName.Name = "Check_IncludeDeviceName";
            this.Check_IncludeDeviceName.Size = new System.Drawing.Size(195, 17);
            this.Check_IncludeDeviceName.TabIndex = 21;
            this.Check_IncludeDeviceName.Text = "Include device name in copy history";
            this.Check_IncludeDeviceName.UseVisualStyleBackColor = true;
            // 
            // GroupBox_OnlineBehaviour
            // 
            this.GroupBox_OnlineBehaviour.Controls.Add(this.Check_LimitTraffic);
            this.GroupBox_OnlineBehaviour.Controls.Add(this.Label_OnlineBehaviourExplanation);
            this.GroupBox_OnlineBehaviour.Controls.Add(this.Radio_ReceiveOnly);
            this.GroupBox_OnlineBehaviour.Controls.Add(this.Radio_SendOnly);
            this.GroupBox_OnlineBehaviour.Location = new System.Drawing.Point(6, 100);
            this.GroupBox_OnlineBehaviour.Name = "GroupBox_OnlineBehaviour";
            this.GroupBox_OnlineBehaviour.Size = new System.Drawing.Size(337, 171);
            this.GroupBox_OnlineBehaviour.TabIndex = 0;
            this.GroupBox_OnlineBehaviour.TabStop = false;
            this.GroupBox_OnlineBehaviour.Text = "Application Online behaviour";
            // 
            // Check_LimitTraffic
            // 
            this.Check_LimitTraffic.AutoSize = true;
            this.Check_LimitTraffic.Location = new System.Drawing.Point(6, 79);
            this.Check_LimitTraffic.Name = "Check_LimitTraffic";
            this.Check_LimitTraffic.Size = new System.Drawing.Size(76, 17);
            this.Check_LimitTraffic.TabIndex = 18;
            this.Check_LimitTraffic.Text = "Limit traffic";
            this.Check_LimitTraffic.UseVisualStyleBackColor = true;
            // 
            // Label_OnlineBehaviourExplanation
            // 
            this.Label_OnlineBehaviourExplanation.AutoSize = true;
            this.Label_OnlineBehaviourExplanation.Location = new System.Drawing.Point(6, 26);
            this.Label_OnlineBehaviourExplanation.Name = "Label_OnlineBehaviourExplanation";
            this.Label_OnlineBehaviourExplanation.Size = new System.Drawing.Size(184, 26);
            this.Label_OnlineBehaviourExplanation.TabIndex = 30;
            this.Label_OnlineBehaviourExplanation.Text = "Set how the application will handle\r\nonline interactions with other devices.";
            // 
            // Radio_ReceiveOnly
            // 
            this.Radio_ReceiveOnly.AutoSize = true;
            this.Radio_ReceiveOnly.Checked = true;
            this.Radio_ReceiveOnly.Location = new System.Drawing.Point(6, 140);
            this.Radio_ReceiveOnly.Name = "Radio_ReceiveOnly";
            this.Radio_ReceiveOnly.Size = new System.Drawing.Size(87, 17);
            this.Radio_ReceiveOnly.TabIndex = 20;
            this.Radio_ReceiveOnly.TabStop = true;
            this.Radio_ReceiveOnly.Text = "Receive only";
            this.Radio_ReceiveOnly.UseVisualStyleBackColor = true;
            // 
            // Radio_SendOnly
            // 
            this.Radio_SendOnly.AutoSize = true;
            this.Radio_SendOnly.Location = new System.Drawing.Point(6, 110);
            this.Radio_SendOnly.Name = "Radio_SendOnly";
            this.Radio_SendOnly.Size = new System.Drawing.Size(72, 17);
            this.Radio_SendOnly.TabIndex = 19;
            this.Radio_SendOnly.Text = "Send only";
            this.Radio_SendOnly.UseVisualStyleBackColor = true;
            // 
            // GroupBox_SaveToFileSettings
            // 
            this.GroupBox_SaveToFileSettings.Controls.Add(this.Label_WriteRealTimeInfo);
            this.GroupBox_SaveToFileSettings.Controls.Add(this.Check_WriteInRealTime);
            this.GroupBox_SaveToFileSettings.Controls.Add(this.Btn_Browse);
            this.GroupBox_SaveToFileSettings.Controls.Add(this.Label_FileLocation);
            this.GroupBox_SaveToFileSettings.Controls.Add(this.txt_FileLocation);
            this.GroupBox_SaveToFileSettings.Location = new System.Drawing.Point(362, 25);
            this.GroupBox_SaveToFileSettings.Name = "GroupBox_SaveToFileSettings";
            this.GroupBox_SaveToFileSettings.Size = new System.Drawing.Size(350, 189);
            this.GroupBox_SaveToFileSettings.TabIndex = 0;
            this.GroupBox_SaveToFileSettings.TabStop = false;
            this.GroupBox_SaveToFileSettings.Text = "Save to file settings";
            // 
            // Label_WriteRealTimeInfo
            // 
            this.Label_WriteRealTimeInfo.AutoSize = true;
            this.Label_WriteRealTimeInfo.Location = new System.Drawing.Point(33, 94);
            this.Label_WriteRealTimeInfo.Name = "Label_WriteRealTimeInfo";
            this.Label_WriteRealTimeInfo.Size = new System.Drawing.Size(156, 39);
            this.Label_WriteRealTimeInfo.TabIndex = 6;
            this.Label_WriteRealTimeInfo.Text = "If real time is turned off, the\r\napplication will only access and\r\nwrite to the f" +
    "ile when it\'s closed.";
            // 
            // Check_WriteInRealTime
            // 
            this.Check_WriteInRealTime.AutoSize = true;
            this.Check_WriteInRealTime.Enabled = false;
            this.Check_WriteInRealTime.Location = new System.Drawing.Point(6, 67);
            this.Check_WriteInRealTime.Name = "Check_WriteInRealTime";
            this.Check_WriteInRealTime.Size = new System.Drawing.Size(120, 17);
            this.Check_WriteInRealTime.TabIndex = 16;
            this.Check_WriteInRealTime.Text = "Write file in real time";
            this.Check_WriteInRealTime.UseVisualStyleBackColor = true;
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.Enabled = false;
            this.Btn_Browse.Location = new System.Drawing.Point(266, 39);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(78, 26);
            this.Btn_Browse.TabIndex = 15;
            this.Btn_Browse.Text = "Browse";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            // 
            // Label_FileLocation
            // 
            this.Label_FileLocation.AutoSize = true;
            this.Label_FileLocation.Location = new System.Drawing.Point(6, 22);
            this.Label_FileLocation.Name = "Label_FileLocation";
            this.Label_FileLocation.Size = new System.Drawing.Size(63, 13);
            this.Label_FileLocation.TabIndex = 1;
            this.Label_FileLocation.Text = "File location";
            // 
            // txt_FileLocation
            // 
            this.txt_FileLocation.Enabled = false;
            this.txt_FileLocation.Location = new System.Drawing.Point(6, 42);
            this.txt_FileLocation.Name = "txt_FileLocation";
            this.txt_FileLocation.Size = new System.Drawing.Size(254, 20);
            this.txt_FileLocation.TabIndex = 14;
            // 
            // GroupBox_BehaviourAndVisuals
            // 
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_UseTimestamp);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_OpenWithWin);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Label_Minutes);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_OnlineMode);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.combo_lang);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Label_Lang);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.DONOTMODIFY7);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_ShowDonation);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.DONOTMODIFY6);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Radio_ExitApp);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Radio_Minimize);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Label_WhenMainWindowClosed);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.DONOTMODIFY5);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_StartMinimized);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.label9);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.DONOTMODIFY4);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.DONOTMODIFY3);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.DONOTMODIFY2);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.DONOTMODIFY1);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.numeric_clearAfter);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Label_Every);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_AutoClearClipboard);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_SaveToFile);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_NotifyOfCopy);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_UseWhiteIcon);
            this.GroupBox_BehaviourAndVisuals.Location = new System.Drawing.Point(6, 25);
            this.GroupBox_BehaviourAndVisuals.Name = "GroupBox_BehaviourAndVisuals";
            this.GroupBox_BehaviourAndVisuals.Size = new System.Drawing.Size(350, 643);
            this.GroupBox_BehaviourAndVisuals.TabIndex = 0;
            this.GroupBox_BehaviourAndVisuals.TabStop = false;
            this.GroupBox_BehaviourAndVisuals.Text = "Behaviour and visuals";
            // 
            // Check_UseTimestamp
            // 
            this.Check_UseTimestamp.AutoSize = true;
            this.Check_UseTimestamp.Location = new System.Drawing.Point(6, 111);
            this.Check_UseTimestamp.Name = "Check_UseTimestamp";
            this.Check_UseTimestamp.Size = new System.Drawing.Size(99, 17);
            this.Check_UseTimestamp.TabIndex = 3;
            this.Check_UseTimestamp.Text = "Use Timestamp";
            this.Check_UseTimestamp.UseVisualStyleBackColor = true;
            // 
            // Check_OpenWithWin
            // 
            this.Check_OpenWithWin.AutoSize = true;
            this.Check_OpenWithWin.Location = new System.Drawing.Point(6, 285);
            this.Check_OpenWithWin.Name = "Check_OpenWithWin";
            this.Check_OpenWithWin.Size = new System.Drawing.Size(124, 17);
            this.Check_OpenWithWin.TabIndex = 7;
            this.Check_OpenWithWin.Text = "Open With Windows";
            this.Check_OpenWithWin.UseVisualStyleBackColor = true;
            // 
            // Label_Minutes
            // 
            this.Label_Minutes.AutoSize = true;
            this.Label_Minutes.Location = new System.Drawing.Point(205, 229);
            this.Label_Minutes.Name = "Label_Minutes";
            this.Label_Minutes.Size = new System.Drawing.Size(44, 13);
            this.Label_Minutes.TabIndex = 24;
            this.Label_Minutes.Text = "Minutes";
            // 
            // Check_OnlineMode
            // 
            this.Check_OnlineMode.AutoSize = true;
            this.Check_OnlineMode.Location = new System.Drawing.Point(6, 350);
            this.Check_OnlineMode.Name = "Check_OnlineMode";
            this.Check_OnlineMode.Size = new System.Drawing.Size(86, 17);
            this.Check_OnlineMode.TabIndex = 9;
            this.Check_OnlineMode.Text = "Online Mode";
            this.Check_OnlineMode.UseVisualStyleBackColor = true;
            // 
            // combo_lang
            // 
            this.combo_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_lang.FormattingEnabled = true;
            this.combo_lang.Items.AddRange(new object[] {
            "English",
            "Hungarian",
            "Norwegian",
            "Finnish",
            "Filipino",
            "Dutch",
            "Serbian",
            "Danish",
            "Polish",
            "Slovak",
            "Portuguese"});
            this.combo_lang.Location = new System.Drawing.Point(104, 563);
            this.combo_lang.Name = "combo_lang";
            this.combo_lang.Size = new System.Drawing.Size(116, 21);
            this.combo_lang.TabIndex = 13;
            this.combo_lang.SelectedIndexChanged += new System.EventHandler(this.Combo_lang_SelectedIndexChanged);
            // 
            // Label_Lang
            // 
            this.Label_Lang.AutoSize = true;
            this.Label_Lang.Location = new System.Drawing.Point(3, 566);
            this.Label_Lang.Name = "Label_Lang";
            this.Label_Lang.Size = new System.Drawing.Size(55, 13);
            this.Label_Lang.TabIndex = 22;
            this.Label_Lang.Text = "Language";
            // 
            // DONOTMODIFY7
            // 
            this.DONOTMODIFY7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY7.Location = new System.Drawing.Point(0, 547);
            this.DONOTMODIFY7.Name = "DONOTMODIFY7";
            this.DONOTMODIFY7.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY7.TabIndex = 21;
            // 
            // Check_ShowDonation
            // 
            this.Check_ShowDonation.AutoSize = true;
            this.Check_ShowDonation.Checked = true;
            this.Check_ShowDonation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_ShowDonation.Location = new System.Drawing.Point(6, 513);
            this.Check_ShowDonation.Name = "Check_ShowDonation";
            this.Check_ShowDonation.Size = new System.Drawing.Size(209, 17);
            this.Check_ShowDonation.TabIndex = 12;
            this.Check_ShowDonation.Text = "Show donation button on main window";
            this.Check_ShowDonation.UseVisualStyleBackColor = true;
            // 
            // DONOTMODIFY6
            // 
            this.DONOTMODIFY6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY6.Location = new System.Drawing.Point(0, 491);
            this.DONOTMODIFY6.Name = "DONOTMODIFY6";
            this.DONOTMODIFY6.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY6.TabIndex = 19;
            // 
            // Radio_ExitApp
            // 
            this.Radio_ExitApp.AutoSize = true;
            this.Radio_ExitApp.Checked = true;
            this.Radio_ExitApp.Location = new System.Drawing.Point(6, 456);
            this.Radio_ExitApp.Name = "Radio_ExitApp";
            this.Radio_ExitApp.Size = new System.Drawing.Size(114, 17);
            this.Radio_ExitApp.TabIndex = 11;
            this.Radio_ExitApp.TabStop = true;
            this.Radio_ExitApp.Text = "Exit the application";
            this.Radio_ExitApp.UseVisualStyleBackColor = true;
            // 
            // Radio_Minimize
            // 
            this.Radio_Minimize.AutoSize = true;
            this.Radio_Minimize.Location = new System.Drawing.Point(6, 428);
            this.Radio_Minimize.Name = "Radio_Minimize";
            this.Radio_Minimize.Size = new System.Drawing.Size(135, 17);
            this.Radio_Minimize.TabIndex = 10;
            this.Radio_Minimize.Text = "Minimize on system tray";
            this.Radio_Minimize.UseVisualStyleBackColor = true;
            // 
            // Label_WhenMainWindowClosed
            // 
            this.Label_WhenMainWindowClosed.AutoSize = true;
            this.Label_WhenMainWindowClosed.Location = new System.Drawing.Point(6, 405);
            this.Label_WhenMainWindowClosed.Name = "Label_WhenMainWindowClosed";
            this.Label_WhenMainWindowClosed.Size = new System.Drawing.Size(158, 13);
            this.Label_WhenMainWindowClosed.TabIndex = 16;
            this.Label_WhenMainWindowClosed.Text = "When I close the main Window:";
            // 
            // DONOTMODIFY5
            // 
            this.DONOTMODIFY5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY5.Location = new System.Drawing.Point(0, 385);
            this.DONOTMODIFY5.Name = "DONOTMODIFY5";
            this.DONOTMODIFY5.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY5.TabIndex = 15;
            // 
            // Check_StartMinimized
            // 
            this.Check_StartMinimized.AutoSize = true;
            this.Check_StartMinimized.Location = new System.Drawing.Point(6, 317);
            this.Check_StartMinimized.Name = "Check_StartMinimized";
            this.Check_StartMinimized.Size = new System.Drawing.Size(97, 17);
            this.Check_StartMinimized.TabIndex = 8;
            this.Check_StartMinimized.Text = "Start Minimized";
            this.Check_StartMinimized.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(355, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 2);
            this.label9.TabIndex = 13;
            // 
            // DONOTMODIFY4
            // 
            this.DONOTMODIFY4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY4.Location = new System.Drawing.Point(0, 266);
            this.DONOTMODIFY4.Name = "DONOTMODIFY4";
            this.DONOTMODIFY4.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY4.TabIndex = 12;
            // 
            // DONOTMODIFY3
            // 
            this.DONOTMODIFY3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY3.Location = new System.Drawing.Point(0, 187);
            this.DONOTMODIFY3.Name = "DONOTMODIFY3";
            this.DONOTMODIFY3.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY3.TabIndex = 11;
            // 
            // DONOTMODIFY2
            // 
            this.DONOTMODIFY2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY2.Location = new System.Drawing.Point(0, 142);
            this.DONOTMODIFY2.Name = "DONOTMODIFY2";
            this.DONOTMODIFY2.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY2.TabIndex = 10;
            // 
            // DONOTMODIFY1
            // 
            this.DONOTMODIFY1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY1.Location = new System.Drawing.Point(0, 67);
            this.DONOTMODIFY1.Name = "DONOTMODIFY1";
            this.DONOTMODIFY1.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY1.TabIndex = 2;
            // 
            // numeric_clearAfter
            // 
            this.numeric_clearAfter.Enabled = false;
            this.numeric_clearAfter.Location = new System.Drawing.Point(79, 227);
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
            this.numeric_clearAfter.Size = new System.Drawing.Size(120, 20);
            this.numeric_clearAfter.TabIndex = 6;
            this.numeric_clearAfter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label_Every
            // 
            this.Label_Every.AutoSize = true;
            this.Label_Every.Location = new System.Drawing.Point(25, 229);
            this.Label_Every.Name = "Label_Every";
            this.Label_Every.Size = new System.Drawing.Size(34, 13);
            this.Label_Every.TabIndex = 6;
            this.Label_Every.Text = "Every";
            // 
            // Check_AutoClearClipboard
            // 
            this.Check_AutoClearClipboard.AutoSize = true;
            this.Check_AutoClearClipboard.Location = new System.Drawing.Point(6, 202);
            this.Check_AutoClearClipboard.Name = "Check_AutoClearClipboard";
            this.Check_AutoClearClipboard.Size = new System.Drawing.Size(209, 17);
            this.Check_AutoClearClipboard.TabIndex = 5;
            this.Check_AutoClearClipboard.Text = "Automatically clear my clipboard history";
            this.Check_AutoClearClipboard.UseVisualStyleBackColor = true;
            // 
            // Check_SaveToFile
            // 
            this.Check_SaveToFile.AutoSize = true;
            this.Check_SaveToFile.Location = new System.Drawing.Point(6, 156);
            this.Check_SaveToFile.Name = "Check_SaveToFile";
            this.Check_SaveToFile.Size = new System.Drawing.Size(230, 17);
            this.Check_SaveToFile.TabIndex = 4;
            this.Check_SaveToFile.Text = "Save the clipboard history to a local text file";
            this.Check_SaveToFile.UseVisualStyleBackColor = true;
            // 
            // Check_NotifyOfCopy
            // 
            this.Check_NotifyOfCopy.AutoSize = true;
            this.Check_NotifyOfCopy.Location = new System.Drawing.Point(6, 83);
            this.Check_NotifyOfCopy.Name = "Check_NotifyOfCopy";
            this.Check_NotifyOfCopy.Size = new System.Drawing.Size(205, 17);
            this.Check_NotifyOfCopy.TabIndex = 2;
            this.Check_NotifyOfCopy.Text = "Notify me when my clipboard changes";
            this.Check_NotifyOfCopy.UseVisualStyleBackColor = true;
            // 
            // Check_UseWhiteIcon
            // 
            this.Check_UseWhiteIcon.AutoSize = true;
            this.Check_UseWhiteIcon.Location = new System.Drawing.Point(6, 33);
            this.Check_UseWhiteIcon.Name = "Check_UseWhiteIcon";
            this.Check_UseWhiteIcon.Size = new System.Drawing.Size(180, 17);
            this.Check_UseWhiteIcon.TabIndex = 1;
            this.Check_UseWhiteIcon.Text = "Use white icon in the system tray";
            this.Check_UseWhiteIcon.UseVisualStyleBackColor = true;
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Apply.Location = new System.Drawing.Point(615, 686);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new System.Drawing.Size(117, 53);
            this.Btn_Apply.TabIndex = 22;
            this.Btn_Apply.Text = "Apply";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Version.Location = new System.Drawing.Point(7, 713);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(95, 29);
            this.Label_Version.TabIndex = 5;
            this.Label_Version.Text = "Version";
            // 
            // Group_GroupSettings
            // 
            this.Group_GroupSettings.Controls.Add(this.Btn_ShowPassword);
            this.Group_GroupSettings.Controls.Add(this.Btn_Generate);
            this.Group_GroupSettings.Controls.Add(this.txt_Password);
            this.Group_GroupSettings.Controls.Add(this.txt_GroupId);
            this.Group_GroupSettings.Controls.Add(this.Label_Password);
            this.Group_GroupSettings.Controls.Add(this.Label_GroupId);
            this.Group_GroupSettings.Location = new System.Drawing.Point(6, 277);
            this.Group_GroupSettings.Name = "Group_GroupSettings";
            this.Group_GroupSettings.Size = new System.Drawing.Size(337, 136);
            this.Group_GroupSettings.TabIndex = 22;
            this.Group_GroupSettings.TabStop = false;
            this.Group_GroupSettings.Text = "Online Connections";
            // 
            // Label_GroupId
            // 
            this.Label_GroupId.AutoSize = true;
            this.Label_GroupId.Location = new System.Drawing.Point(3, 27);
            this.Label_GroupId.Name = "Label_GroupId";
            this.Label_GroupId.Size = new System.Drawing.Size(102, 13);
            this.Label_GroupId.TabIndex = 0;
            this.Label_GroupId.Text = "Username (GroupId)";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(3, 75);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(53, 13);
            this.Label_Password.TabIndex = 1;
            this.Label_Password.Text = "Password";
            // 
            // txt_GroupId
            // 
            this.txt_GroupId.Location = new System.Drawing.Point(6, 43);
            this.txt_GroupId.Name = "txt_GroupId";
            this.txt_GroupId.Size = new System.Drawing.Size(230, 20);
            this.txt_GroupId.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(6, 92);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(230, 20);
            this.txt_Password.TabIndex = 3;
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(242, 43);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(89, 20);
            this.Btn_Generate.TabIndex = 4;
            this.Btn_Generate.Text = "Generate";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.Location = new System.Drawing.Point(242, 92);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.Size = new System.Drawing.Size(89, 20);
            this.Btn_ShowPassword.TabIndex = 5;
            this.Btn_ShowPassword.Text = "Show";
            this.Btn_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(748, 751);
            this.ControlBox = false;
            this.Controls.Add(this.Label_Version);
            this.Controls.Add(this.Btn_Apply);
            this.Controls.Add(this.GroupBox_General);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.GroupBox_General.ResumeLayout(false);
            this.GroupBox_OnlineSettings.ResumeLayout(false);
            this.GroupBox_OnlineSettings.PerformLayout();
            this.GroupBox_TimeBeforeReconnect.ResumeLayout(false);
            this.GroupBox_TimeBeforeReconnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ReconnectDelay)).EndInit();
            this.GroupBox_OnlineBehaviour.ResumeLayout(false);
            this.GroupBox_OnlineBehaviour.PerformLayout();
            this.GroupBox_SaveToFileSettings.ResumeLayout(false);
            this.GroupBox_SaveToFileSettings.PerformLayout();
            this.GroupBox_BehaviourAndVisuals.ResumeLayout(false);
            this.GroupBox_BehaviourAndVisuals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clearAfter)).EndInit();
            this.Group_GroupSettings.ResumeLayout(false);
            this.Group_GroupSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_General;
        private System.Windows.Forms.GroupBox GroupBox_SaveToFileSettings;
        private System.Windows.Forms.GroupBox GroupBox_BehaviourAndVisuals;
        private System.Windows.Forms.CheckBox Check_SaveToFile;
        private System.Windows.Forms.CheckBox Check_NotifyOfCopy;
        private System.Windows.Forms.CheckBox Check_UseWhiteIcon;
        private System.Windows.Forms.NumericUpDown numeric_clearAfter;
        private System.Windows.Forms.Label Label_Every;
        private System.Windows.Forms.CheckBox Check_AutoClearClipboard;
        private System.Windows.Forms.Label DONOTMODIFY4;
        private System.Windows.Forms.Label DONOTMODIFY3;
        private System.Windows.Forms.Label DONOTMODIFY2;
        private System.Windows.Forms.Label DONOTMODIFY1;
        private System.Windows.Forms.Button Btn_Browse;
        private System.Windows.Forms.Label Label_FileLocation;
        private System.Windows.Forms.TextBox txt_FileLocation;
        private System.Windows.Forms.Label Label_WriteRealTimeInfo;
        private System.Windows.Forms.CheckBox Check_WriteInRealTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Apply;
        private System.Windows.Forms.CheckBox Check_StartMinimized;
        private System.Windows.Forms.Label DONOTMODIFY5;
        private System.Windows.Forms.RadioButton Radio_ExitApp;
        private System.Windows.Forms.RadioButton Radio_Minimize;
        private System.Windows.Forms.Label Label_WhenMainWindowClosed;
        private System.Windows.Forms.Label DONOTMODIFY6;
        private System.Windows.Forms.CheckBox Check_ShowDonation;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.Label DONOTMODIFY7;
        private System.Windows.Forms.ComboBox combo_lang;
        private System.Windows.Forms.Label Label_Lang;
        private System.Windows.Forms.Label Label_Minutes;
        private System.Windows.Forms.CheckBox Check_OpenWithWin;
        private System.Windows.Forms.CheckBox Check_OnlineMode;
        private System.Windows.Forms.CheckBox Check_UseTimestamp;
        private System.Windows.Forms.GroupBox GroupBox_OnlineSettings;
        private System.Windows.Forms.CheckBox Check_IncludeDeviceName;
        private System.Windows.Forms.GroupBox GroupBox_OnlineBehaviour;
        private System.Windows.Forms.Label Label_OnlineBehaviourExplanation;
        private System.Windows.Forms.RadioButton Radio_ReceiveOnly;
        private System.Windows.Forms.RadioButton Radio_SendOnly;
        private System.Windows.Forms.GroupBox GroupBox_TimeBeforeReconnect;
        private System.Windows.Forms.Label Label_Seconds;
        private System.Windows.Forms.NumericUpDown numeric_ReconnectDelay;
        private System.Windows.Forms.CheckBox Check_LimitTraffic;
        private System.Windows.Forms.GroupBox Group_GroupSettings;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_GroupId;
        private System.Windows.Forms.TextBox txt_GroupId;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button Btn_ShowPassword;
        private System.Windows.Forms.Button Btn_Generate;
    }
}