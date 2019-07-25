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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.check_writeInRealTime = new System.Windows.Forms.CheckBox();
            this.radio_replace = new System.Windows.Forms.RadioButton();
            this.radio_append = new System.Windows.Forms.RadioButton();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_FileLocation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.check_openWithWindows = new System.Windows.Forms.CheckBox();
            this.combo_timeFormat = new System.Windows.Forms.ComboBox();
            this.numeric_clearAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.check_AutoClearHistory = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_notifTimeout = new System.Windows.Forms.NumericUpDown();
            this.check_SaveToFile = new System.Windows.Forms.CheckBox();
            this.check_NotifyOfCopy = new System.Windows.Forms.CheckBox();
            this.check_UseWhiteIcon = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clearAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_notifTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.check_writeInRealTime);
            this.groupBox4.Controls.Add(this.radio_replace);
            this.groupBox4.Controls.Add(this.radio_append);
            this.groupBox4.Controls.Add(this.btn_browse);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_FileLocation);
            this.groupBox4.Location = new System.Drawing.Point(362, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 253);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save to file settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 80);
            this.label8.TabIndex = 6;
            this.label8.Text = "Appending or writing to the file in real time\r\nmight be useful for a couple of us" +
    "es, but\r\non lower-end systems, it might degrade\r\nperformance by a small amount.";
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
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "File location";
            // 
            // txt_FileLocation
            // 
            this.txt_FileLocation.Enabled = false;
            this.txt_FileLocation.Location = new System.Drawing.Point(6, 48);
            this.txt_FileLocation.Name = "txt_FileLocation";
            this.txt_FileLocation.Size = new System.Drawing.Size(254, 26);
            this.txt_FileLocation.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.check_openWithWindows);
            this.groupBox2.Controls.Add(this.combo_timeFormat);
            this.groupBox2.Controls.Add(this.numeric_clearAfter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.check_AutoClearHistory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numeric_notifTimeout);
            this.groupBox2.Controls.Add(this.check_SaveToFile);
            this.groupBox2.Controls.Add(this.check_NotifyOfCopy);
            this.groupBox2.Controls.Add(this.check_UseWhiteIcon);
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Behaviour and visuals";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Every";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Show notification for: (seconds)";
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
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(492, 308);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(117, 53);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(615, 308);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 53);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(748, 371);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clearAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_notifTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_notifTimeout;
        private System.Windows.Forms.CheckBox check_SaveToFile;
        private System.Windows.Forms.CheckBox check_NotifyOfCopy;
        private System.Windows.Forms.CheckBox check_UseWhiteIcon;
        private System.Windows.Forms.ComboBox combo_timeFormat;
        private System.Windows.Forms.NumericUpDown numeric_clearAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_AutoClearHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_openWithWindows;
        private System.Windows.Forms.RadioButton radio_replace;
        private System.Windows.Forms.RadioButton radio_append;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_FileLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox check_writeInRealTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_close;
    }
}