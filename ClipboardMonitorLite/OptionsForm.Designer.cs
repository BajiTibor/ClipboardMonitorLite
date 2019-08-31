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
            this.GroupBox_SaveToFileSettings = new System.Windows.Forms.GroupBox();
            this.Label_WriteRealTimeInfo = new System.Windows.Forms.Label();
            this.Check_WriteInRealTime = new System.Windows.Forms.CheckBox();
            this.Btn_Browse = new System.Windows.Forms.Button();
            this.Label_FileLocation = new System.Windows.Forms.Label();
            this.txt_FileLocation = new System.Windows.Forms.TextBox();
            this.GroupBox_BehaviourAndVisuals = new System.Windows.Forms.GroupBox();
            this.Check_OpenWithWin = new System.Windows.Forms.CheckBox();
            this.Label_Minutes = new System.Windows.Forms.Label();
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Label_Version = new System.Windows.Forms.Label();
            this.Check_OnlineMode = new System.Windows.Forms.CheckBox();
            this.GroupBox_General.SuspendLayout();
            this.GroupBox_SaveToFileSettings.SuspendLayout();
            this.GroupBox_BehaviourAndVisuals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clearAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_General
            // 
            this.GroupBox_General.Controls.Add(this.GroupBox_SaveToFileSettings);
            this.GroupBox_General.Controls.Add(this.GroupBox_BehaviourAndVisuals);
            this.GroupBox_General.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_General.Name = "GroupBox_General";
            this.GroupBox_General.Size = new System.Drawing.Size(720, 561);
            this.GroupBox_General.TabIndex = 0;
            this.GroupBox_General.TabStop = false;
            this.GroupBox_General.Text = "General";
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
            this.GroupBox_SaveToFileSettings.Size = new System.Drawing.Size(350, 217);
            this.GroupBox_SaveToFileSettings.TabIndex = 1;
            this.GroupBox_SaveToFileSettings.TabStop = false;
            this.GroupBox_SaveToFileSettings.Text = "Save to file settings";
            // 
            // Label_WriteRealTimeInfo
            // 
            this.Label_WriteRealTimeInfo.AutoSize = true;
            this.Label_WriteRealTimeInfo.Location = new System.Drawing.Point(33, 137);
            this.Label_WriteRealTimeInfo.Name = "Label_WriteRealTimeInfo";
            this.Label_WriteRealTimeInfo.Size = new System.Drawing.Size(123, 20);
            this.Label_WriteRealTimeInfo.TabIndex = 6;
            this.Label_WriteRealTimeInfo.Text = "RealtimeExplain";
            // 
            // Check_WriteInRealTime
            // 
            this.Check_WriteInRealTime.AutoSize = true;
            this.Check_WriteInRealTime.Enabled = false;
            this.Check_WriteInRealTime.Location = new System.Drawing.Point(6, 86);
            this.Check_WriteInRealTime.Name = "Check_WriteInRealTime";
            this.Check_WriteInRealTime.Size = new System.Drawing.Size(176, 24);
            this.Check_WriteInRealTime.TabIndex = 13;
            this.Check_WriteInRealTime.Text = "Write file in real time";
            this.Check_WriteInRealTime.UseVisualStyleBackColor = true;
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.Enabled = false;
            this.Btn_Browse.Location = new System.Drawing.Point(266, 48);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(78, 26);
            this.Btn_Browse.TabIndex = 12;
            this.Btn_Browse.Text = "Browse";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            // 
            // Label_FileLocation
            // 
            this.Label_FileLocation.AutoSize = true;
            this.Label_FileLocation.Location = new System.Drawing.Point(6, 25);
            this.Label_FileLocation.Name = "Label_FileLocation";
            this.Label_FileLocation.Size = new System.Drawing.Size(93, 20);
            this.Label_FileLocation.TabIndex = 1;
            this.Label_FileLocation.Text = "File location";
            // 
            // txt_FileLocation
            // 
            this.txt_FileLocation.Enabled = false;
            this.txt_FileLocation.Location = new System.Drawing.Point(6, 48);
            this.txt_FileLocation.Name = "txt_FileLocation";
            this.txt_FileLocation.Size = new System.Drawing.Size(254, 26);
            this.txt_FileLocation.TabIndex = 11;
            // 
            // GroupBox_BehaviourAndVisuals
            // 
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_OnlineMode);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Check_OpenWithWin);
            this.GroupBox_BehaviourAndVisuals.Controls.Add(this.Label_Minutes);
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
            this.GroupBox_BehaviourAndVisuals.Size = new System.Drawing.Size(350, 530);
            this.GroupBox_BehaviourAndVisuals.TabIndex = 1;
            this.GroupBox_BehaviourAndVisuals.TabStop = false;
            this.GroupBox_BehaviourAndVisuals.Text = "Behaviour and visuals";
            // 
            // Check_OpenWithWin
            // 
            this.Check_OpenWithWin.AutoSize = true;
            this.Check_OpenWithWin.Location = new System.Drawing.Point(6, 223);
            this.Check_OpenWithWin.Name = "Check_OpenWithWin";
            this.Check_OpenWithWin.Size = new System.Drawing.Size(178, 24);
            this.Check_OpenWithWin.TabIndex = 25;
            this.Check_OpenWithWin.Text = "Open With Windows";
            this.Check_OpenWithWin.UseVisualStyleBackColor = true;
            // 
            // Label_Minutes
            // 
            this.Label_Minutes.AutoSize = true;
            this.Label_Minutes.Location = new System.Drawing.Point(205, 187);
            this.Label_Minutes.Name = "Label_Minutes";
            this.Label_Minutes.Size = new System.Drawing.Size(65, 20);
            this.Label_Minutes.TabIndex = 24;
            this.Label_Minutes.Text = "Minutes";
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
            "Polish"});
            this.combo_lang.Location = new System.Drawing.Point(103, 445);
            this.combo_lang.Name = "combo_lang";
            this.combo_lang.Size = new System.Drawing.Size(116, 28);
            this.combo_lang.TabIndex = 10;
            this.combo_lang.SelectedIndexChanged += new System.EventHandler(this.Combo_lang_SelectedIndexChanged);
            // 
            // Label_Lang
            // 
            this.Label_Lang.AutoSize = true;
            this.Label_Lang.Location = new System.Drawing.Point(2, 448);
            this.Label_Lang.Name = "Label_Lang";
            this.Label_Lang.Size = new System.Drawing.Size(81, 20);
            this.Label_Lang.TabIndex = 22;
            this.Label_Lang.Text = "Language";
            // 
            // DONOTMODIFY7
            // 
            this.DONOTMODIFY7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY7.Location = new System.Drawing.Point(0, 432);
            this.DONOTMODIFY7.Name = "DONOTMODIFY7";
            this.DONOTMODIFY7.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY7.TabIndex = 21;
            // 
            // Check_ShowDonation
            // 
            this.Check_ShowDonation.AutoSize = true;
            this.Check_ShowDonation.Checked = true;
            this.Check_ShowDonation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_ShowDonation.Location = new System.Drawing.Point(6, 402);
            this.Check_ShowDonation.Name = "Check_ShowDonation";
            this.Check_ShowDonation.Size = new System.Drawing.Size(307, 24);
            this.Check_ShowDonation.TabIndex = 9;
            this.Check_ShowDonation.Text = "Show donation button on main window";
            this.Check_ShowDonation.UseVisualStyleBackColor = true;
            // 
            // DONOTMODIFY6
            // 
            this.DONOTMODIFY6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY6.Location = new System.Drawing.Point(0, 392);
            this.DONOTMODIFY6.Name = "DONOTMODIFY6";
            this.DONOTMODIFY6.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY6.TabIndex = 19;
            // 
            // Radio_ExitApp
            // 
            this.Radio_ExitApp.AutoSize = true;
            this.Radio_ExitApp.Checked = true;
            this.Radio_ExitApp.Location = new System.Drawing.Point(6, 365);
            this.Radio_ExitApp.Name = "Radio_ExitApp";
            this.Radio_ExitApp.Size = new System.Drawing.Size(167, 24);
            this.Radio_ExitApp.TabIndex = 8;
            this.Radio_ExitApp.TabStop = true;
            this.Radio_ExitApp.Text = "Exit the application";
            this.Radio_ExitApp.UseVisualStyleBackColor = true;
            // 
            // Radio_Minimize
            // 
            this.Radio_Minimize.AutoSize = true;
            this.Radio_Minimize.Location = new System.Drawing.Point(6, 337);
            this.Radio_Minimize.Name = "Radio_Minimize";
            this.Radio_Minimize.Size = new System.Drawing.Size(201, 24);
            this.Radio_Minimize.TabIndex = 7;
            this.Radio_Minimize.Text = "Minimize on system tray";
            this.Radio_Minimize.UseVisualStyleBackColor = true;
            // 
            // Label_WhenMainWindowClosed
            // 
            this.Label_WhenMainWindowClosed.AutoSize = true;
            this.Label_WhenMainWindowClosed.Location = new System.Drawing.Point(6, 314);
            this.Label_WhenMainWindowClosed.Name = "Label_WhenMainWindowClosed";
            this.Label_WhenMainWindowClosed.Size = new System.Drawing.Size(230, 20);
            this.Label_WhenMainWindowClosed.TabIndex = 16;
            this.Label_WhenMainWindowClosed.Text = "When I close the main Window:";
            // 
            // DONOTMODIFY5
            // 
            this.DONOTMODIFY5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY5.Location = new System.Drawing.Point(0, 312);
            this.DONOTMODIFY5.Name = "DONOTMODIFY5";
            this.DONOTMODIFY5.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY5.TabIndex = 15;
            // 
            // Check_StartMinimized
            // 
            this.Check_StartMinimized.AutoSize = true;
            this.Check_StartMinimized.Location = new System.Drawing.Point(6, 253);
            this.Check_StartMinimized.Name = "Check_StartMinimized";
            this.Check_StartMinimized.Size = new System.Drawing.Size(144, 24);
            this.Check_StartMinimized.TabIndex = 6;
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
            this.DONOTMODIFY4.Location = new System.Drawing.Point(0, 215);
            this.DONOTMODIFY4.Name = "DONOTMODIFY4";
            this.DONOTMODIFY4.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY4.TabIndex = 12;
            // 
            // DONOTMODIFY3
            // 
            this.DONOTMODIFY3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY3.Location = new System.Drawing.Point(0, 155);
            this.DONOTMODIFY3.Name = "DONOTMODIFY3";
            this.DONOTMODIFY3.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY3.TabIndex = 11;
            // 
            // DONOTMODIFY2
            // 
            this.DONOTMODIFY2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY2.Location = new System.Drawing.Point(0, 115);
            this.DONOTMODIFY2.Name = "DONOTMODIFY2";
            this.DONOTMODIFY2.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY2.TabIndex = 10;
            // 
            // DONOTMODIFY1
            // 
            this.DONOTMODIFY1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DONOTMODIFY1.Location = new System.Drawing.Point(0, 50);
            this.DONOTMODIFY1.Name = "DONOTMODIFY1";
            this.DONOTMODIFY1.Size = new System.Drawing.Size(350, 2);
            this.DONOTMODIFY1.TabIndex = 2;
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
            this.numeric_clearAfter.TabIndex = 5;
            this.numeric_clearAfter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label_Every
            // 
            this.Label_Every.AutoSize = true;
            this.Label_Every.Location = new System.Drawing.Point(25, 187);
            this.Label_Every.Name = "Label_Every";
            this.Label_Every.Size = new System.Drawing.Size(48, 20);
            this.Label_Every.TabIndex = 6;
            this.Label_Every.Text = "Every";
            // 
            // Check_AutoClearClipboard
            // 
            this.Check_AutoClearClipboard.AutoSize = true;
            this.Check_AutoClearClipboard.Location = new System.Drawing.Point(6, 160);
            this.Check_AutoClearClipboard.Name = "Check_AutoClearClipboard";
            this.Check_AutoClearClipboard.Size = new System.Drawing.Size(309, 24);
            this.Check_AutoClearClipboard.TabIndex = 4;
            this.Check_AutoClearClipboard.Text = "Automatically clear my clipboard history";
            this.Check_AutoClearClipboard.UseVisualStyleBackColor = true;
            // 
            // Check_SaveToFile
            // 
            this.Check_SaveToFile.AutoSize = true;
            this.Check_SaveToFile.Location = new System.Drawing.Point(6, 125);
            this.Check_SaveToFile.Name = "Check_SaveToFile";
            this.Check_SaveToFile.Size = new System.Drawing.Size(337, 24);
            this.Check_SaveToFile.TabIndex = 3;
            this.Check_SaveToFile.Text = "Save the clipboard history to a local text file";
            this.Check_SaveToFile.UseVisualStyleBackColor = true;
            // 
            // Check_NotifyOfCopy
            // 
            this.Check_NotifyOfCopy.AutoSize = true;
            this.Check_NotifyOfCopy.Location = new System.Drawing.Point(6, 71);
            this.Check_NotifyOfCopy.Name = "Check_NotifyOfCopy";
            this.Check_NotifyOfCopy.Size = new System.Drawing.Size(300, 24);
            this.Check_NotifyOfCopy.TabIndex = 2;
            this.Check_NotifyOfCopy.Text = "Notify me when my clipboard changes";
            this.Check_NotifyOfCopy.UseVisualStyleBackColor = true;
            // 
            // Check_UseWhiteIcon
            // 
            this.Check_UseWhiteIcon.AutoSize = true;
            this.Check_UseWhiteIcon.Location = new System.Drawing.Point(6, 25);
            this.Check_UseWhiteIcon.Name = "Check_UseWhiteIcon";
            this.Check_UseWhiteIcon.Size = new System.Drawing.Size(265, 24);
            this.Check_UseWhiteIcon.TabIndex = 1;
            this.Check_UseWhiteIcon.Text = "Use white icon in the system tray";
            this.Check_UseWhiteIcon.UseVisualStyleBackColor = true;
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Location = new System.Drawing.Point(615, 579);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new System.Drawing.Size(117, 53);
            this.Btn_Apply.TabIndex = 14;
            this.Btn_Apply.Text = "Apply";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Location = new System.Drawing.Point(14, 612);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(63, 20);
            this.Label_Version.TabIndex = 5;
            this.Label_Version.Text = "Version";
            // 
            // Check_OnlineMode
            // 
            this.Check_OnlineMode.AutoSize = true;
            this.Check_OnlineMode.Location = new System.Drawing.Point(6, 283);
            this.Check_OnlineMode.Name = "Check_OnlineMode";
            this.Check_OnlineMode.Size = new System.Drawing.Size(124, 24);
            this.Check_OnlineMode.TabIndex = 26;
            this.Check_OnlineMode.Text = "Online Mode";
            this.Check_OnlineMode.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(748, 644);
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
            this.GroupBox_SaveToFileSettings.ResumeLayout(false);
            this.GroupBox_SaveToFileSettings.PerformLayout();
            this.GroupBox_BehaviourAndVisuals.ResumeLayout(false);
            this.GroupBox_BehaviourAndVisuals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clearAfter)).EndInit();
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
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
    }
}