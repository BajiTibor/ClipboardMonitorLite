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
            this.GroupBox_CopiedItems = new System.Windows.Forms.GroupBox();
            this.CopiedItemBox = new System.Windows.Forms.RichTextBox();
            this.Btn_EmptyClipboard = new System.Windows.Forms.Button();
            this.GroupBox_Actions = new System.Windows.Forms.GroupBox();
            this.Btn_MoreOptions = new System.Windows.Forms.Button();
            this.Btn_EmptyHistory = new System.Windows.Forms.Button();
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Donate = new System.Windows.Forms.Button();
            this.timerEmptyClipboard = new System.Windows.Forms.Timer(this.components);
            this.Label_Connected_DONOTMODIFY = new System.Windows.Forms.Label();
            this.Btn_Debug = new System.Windows.Forms.Button();
            this.GroupBox_CopiedItems.SuspendLayout();
            this.GroupBox_Actions.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_CopiedItems
            // 
            this.GroupBox_CopiedItems.Controls.Add(this.CopiedItemBox);
            this.GroupBox_CopiedItems.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_CopiedItems.Name = "GroupBox_CopiedItems";
            this.GroupBox_CopiedItems.Size = new System.Drawing.Size(510, 370);
            this.GroupBox_CopiedItems.TabIndex = 1;
            this.GroupBox_CopiedItems.TabStop = false;
            this.GroupBox_CopiedItems.Text = "Copied items";
            // 
            // CopiedItemBox
            // 
            this.CopiedItemBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CopiedItemBox.Location = new System.Drawing.Point(6, 25);
            this.CopiedItemBox.Name = "CopiedItemBox";
            this.CopiedItemBox.ReadOnly = true;
            this.CopiedItemBox.Size = new System.Drawing.Size(498, 339);
            this.CopiedItemBox.TabIndex = 1;
            this.CopiedItemBox.Text = "";
            // 
            // Btn_EmptyClipboard
            // 
            this.Btn_EmptyClipboard.Location = new System.Drawing.Point(6, 25);
            this.Btn_EmptyClipboard.Name = "Btn_EmptyClipboard";
            this.Btn_EmptyClipboard.Size = new System.Drawing.Size(156, 35);
            this.Btn_EmptyClipboard.TabIndex = 2;
            this.Btn_EmptyClipboard.Text = "Empty Clipboard";
            this.Btn_EmptyClipboard.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Actions
            // 
            this.GroupBox_Actions.Controls.Add(this.Btn_MoreOptions);
            this.GroupBox_Actions.Controls.Add(this.Btn_EmptyHistory);
            this.GroupBox_Actions.Controls.Add(this.Btn_EmptyClipboard);
            this.GroupBox_Actions.Location = new System.Drawing.Point(18, 388);
            this.GroupBox_Actions.Name = "GroupBox_Actions";
            this.GroupBox_Actions.Size = new System.Drawing.Size(170, 155);
            this.GroupBox_Actions.TabIndex = 3;
            this.GroupBox_Actions.TabStop = false;
            this.GroupBox_Actions.Text = "Actions";
            // 
            // Btn_MoreOptions
            // 
            this.Btn_MoreOptions.Location = new System.Drawing.Point(6, 106);
            this.Btn_MoreOptions.Name = "Btn_MoreOptions";
            this.Btn_MoreOptions.Size = new System.Drawing.Size(156, 35);
            this.Btn_MoreOptions.TabIndex = 4;
            this.Btn_MoreOptions.Text = "More options";
            this.Btn_MoreOptions.UseVisualStyleBackColor = true;
            this.Btn_MoreOptions.Click += new System.EventHandler(this.Btn_MoreOptions_Click);
            // 
            // Btn_EmptyHistory
            // 
            this.Btn_EmptyHistory.Location = new System.Drawing.Point(6, 66);
            this.Btn_EmptyHistory.Name = "Btn_EmptyHistory";
            this.Btn_EmptyHistory.Size = new System.Drawing.Size(156, 35);
            this.Btn_EmptyHistory.TabIndex = 3;
            this.Btn_EmptyHistory.Text = "Empty History";
            this.Btn_EmptyHistory.UseVisualStyleBackColor = true;
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
            // Btn_Donate
            // 
            this.Btn_Donate.Image = global::ClipboardMonitorLite.Resources.MainResources.buymc2;
            this.Btn_Donate.Location = new System.Drawing.Point(201, 395);
            this.Btn_Donate.Name = "Btn_Donate";
            this.Btn_Donate.Size = new System.Drawing.Size(315, 70);
            this.Btn_Donate.TabIndex = 5;
            this.Btn_Donate.UseVisualStyleBackColor = true;
            // 
            // timerEmptyClipboard
            // 
            this.timerEmptyClipboard.Interval = 60000;
            // 
            // Label_Connected_DONOTMODIFY
            // 
            this.Label_Connected_DONOTMODIFY.AutoSize = true;
            this.Label_Connected_DONOTMODIFY.Location = new System.Drawing.Point(197, 523);
            this.Label_Connected_DONOTMODIFY.Name = "Label_Connected_DONOTMODIFY";
            this.Label_Connected_DONOTMODIFY.Size = new System.Drawing.Size(90, 20);
            this.Label_Connected_DONOTMODIFY.TabIndex = 6;
            this.Label_Connected_DONOTMODIFY.Text = "Connection";
            // 
            // Btn_Debug
            // 
            this.Btn_Debug.Location = new System.Drawing.Point(401, 494);
            this.Btn_Debug.Name = "Btn_Debug";
            this.Btn_Debug.Size = new System.Drawing.Size(75, 23);
            this.Btn_Debug.TabIndex = 7;
            this.Btn_Debug.Text = "button1";
            this.Btn_Debug.UseVisualStyleBackColor = true;
            this.Btn_Debug.Click += new System.EventHandler(this.Btn_Debug_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(534, 550);
            this.Controls.Add(this.Btn_Debug);
            this.Controls.Add(this.Label_Connected_DONOTMODIFY);
            this.Controls.Add(this.Btn_Donate);
            this.Controls.Add(this.GroupBox_Actions);
            this.Controls.Add(this.GroupBox_CopiedItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Clipboard Monitor Lite";
            this.GroupBox_CopiedItems.ResumeLayout(false);
            this.GroupBox_Actions.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_CopiedItems;
        private System.Windows.Forms.RichTextBox CopiedItemBox;
        private System.Windows.Forms.Button Btn_EmptyClipboard;
        private System.Windows.Forms.GroupBox GroupBox_Actions;
        private System.Windows.Forms.Button Btn_EmptyHistory;
        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Btn_MoreOptions;
        private System.Windows.Forms.Button Btn_Donate;
        private System.Windows.Forms.Timer timerEmptyClipboard;
        private System.Windows.Forms.Label Label_Connected_DONOTMODIFY;
        private System.Windows.Forms.Button Btn_Debug;
    }
}

