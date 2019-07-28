namespace ClipboardMonitorLite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CopiedItemBox = new System.Windows.Forms.RichTextBox();
            this.btn_EmptyClipboard = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_options = new System.Windows.Forms.Button();
            this.btn_ClearHistory = new System.Windows.Forms.Button();
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Donate = new System.Windows.Forms.Button();
            this.timerEmptyClipboard = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CopiedItemBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copied items";
            // 
            // CopiedItemBox
            // 
            this.CopiedItemBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CopiedItemBox.Location = new System.Drawing.Point(6, 25);
            this.CopiedItemBox.Name = "CopiedItemBox";
            this.CopiedItemBox.ReadOnly = true;
            this.CopiedItemBox.Size = new System.Drawing.Size(498, 339);
            this.CopiedItemBox.TabIndex = 0;
            this.CopiedItemBox.Text = "";
            // 
            // btn_EmptyClipboard
            // 
            this.btn_EmptyClipboard.Location = new System.Drawing.Point(6, 25);
            this.btn_EmptyClipboard.Name = "btn_EmptyClipboard";
            this.btn_EmptyClipboard.Size = new System.Drawing.Size(156, 35);
            this.btn_EmptyClipboard.TabIndex = 0;
            this.btn_EmptyClipboard.Text = "Empty Clipboard";
            this.btn_EmptyClipboard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_options);
            this.groupBox3.Controls.Add(this.btn_ClearHistory);
            this.groupBox3.Controls.Add(this.btn_EmptyClipboard);
            this.groupBox3.Location = new System.Drawing.Point(18, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btn_options
            // 
            this.btn_options.Location = new System.Drawing.Point(6, 106);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(156, 35);
            this.btn_options.TabIndex = 2;
            this.btn_options.Text = "More options";
            this.btn_options.UseVisualStyleBackColor = true;
            this.btn_options.Click += new System.EventHandler(this.Btn_options_Click);
            // 
            // btn_ClearHistory
            // 
            this.btn_ClearHistory.Location = new System.Drawing.Point(6, 66);
            this.btn_ClearHistory.Name = "btn_ClearHistory";
            this.btn_ClearHistory.Size = new System.Drawing.Size(156, 35);
            this.btn_ClearHistory.TabIndex = 1;
            this.btn_ClearHistory.Text = "Empty History";
            this.btn_ClearHistory.UseVisualStyleBackColor = true;
            // 
            // notificationIcon
            // 
            this.notificationIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificationIcon.BalloonTipText = "The application is still running, if you\'d like to\r\nterminate it, right click and" +
    " choose Exit.";
            this.notificationIcon.BalloonTipTitle = "App still running";
            this.notificationIcon.ContextMenuStrip = this.MenuStrip;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Text = "Clipboard Monitor Lite";
            this.notificationIcon.Visible = true;
            this.notificationIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationIcon_MouseDoubleClick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.emptyClipboardToolStripMenuItem,
            this.emptyHistoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(219, 132);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItem_Click);
            // 
            // emptyClipboardToolStripMenuItem
            // 
            this.emptyClipboardToolStripMenuItem.Name = "emptyClipboardToolStripMenuItem";
            this.emptyClipboardToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.emptyClipboardToolStripMenuItem.Text = "Empty Clipboard";
            // 
            // emptyHistoryToolStripMenuItem
            // 
            this.emptyHistoryToolStripMenuItem.Name = "emptyHistoryToolStripMenuItem";
            this.emptyHistoryToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.emptyHistoryToolStripMenuItem.Text = "Empty History";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btn_Donate
            // 
            this.btn_Donate.Image = global::ClipboardMonitorLite.Properties.Resources.buymc2;
            this.btn_Donate.Location = new System.Drawing.Point(210, 440);
            this.btn_Donate.Name = "btn_Donate";
            this.btn_Donate.Size = new System.Drawing.Size(315, 70);
            this.btn_Donate.TabIndex = 4;
            this.btn_Donate.UseVisualStyleBackColor = true;
            // 
            // timerEmptyClipboard
            // 
            this.timerEmptyClipboard.Interval = 60000;
            this.timerEmptyClipboard.Tick += new System.EventHandler(this.TimerEmptyClipboard_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(534, 550);
            this.Controls.Add(this.btn_Donate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Clipboard Monitor Lite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox CopiedItemBox;
        private System.Windows.Forms.Button btn_EmptyClipboard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ClearHistory;
        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Button btn_Donate;
        private System.Windows.Forms.Timer timerEmptyClipboard;
    }
}

