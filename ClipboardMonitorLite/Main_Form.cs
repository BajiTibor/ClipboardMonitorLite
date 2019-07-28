﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Reflection;

namespace ClipboardMonitorLite
{
    public partial class MainForm : Form
    {
        private Updates updates;
        private FormActions formActions;
        private TimeCalculate timeToClear;
        private string CurrentlyCopiedItem { get; set; }
        private VirtualClipboard virtualClipboard;
        private ClipboardAction clipboardAction;
        private FileOperation file;
        private StartWithWindows autoRunApplication;
        private Donate donate;
        private ResourceManager resManager;
        public MainForm()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.lang_{Properties.Settings.Default.CurrentLanguage}", 
                Assembly.GetExecutingAssembly());
            updates = new Updates();
            donate = new Donate();
            formActions = new FormActions();
            autoRunApplication = new StartWithWindows();
            virtualClipboard = new VirtualClipboard();
            clipboardAction = new ClipboardAction(virtualClipboard);
            file = new FileOperation("");
            if (Properties.Settings.Default.SaveFileLocation.Equals(string.Empty))
            {
                Properties.Settings.Default.SaveFileLocation = Directory.GetCurrentDirectory()
                    + $"/{file.Format()}";
            }
            file.FilePath = Properties.Settings.Default.SaveFileLocation;
            InitializeComponent();
            InitSettings();
            
            WindowState = Properties.Settings.Default.FormStartState;

            if (Properties.Settings.Default.AutoCheckUpdates)
            {
                updates.Update();
            }

            CopiedItemBox.DataBindings.Add("Text", virtualClipboard, "History",
                true, DataSourceUpdateMode.OnPropertyChanged);

            btn_Donate.DataBindings.Add("Visible", Properties.Settings.Default, "DisplayDonate",
                true, DataSourceUpdateMode.OnPropertyChanged);

            SetLanguage();

            ClipChange.ClipboardUpdate += ClipChange_ClipboardUpdate;
            btn_EmptyClipboard.Click += clipboardAction.ClearClip_Click;
            btn_ClearHistory.Click += clipboardAction.ClearHistory_Click;
            emptyClipboardToolStripMenuItem.Click += clipboardAction.ClearClip_Click;
            emptyHistoryToolStripMenuItem.Click += clipboardAction.ClearHistory_Click;
            exitToolStripMenuItem.Click += formActions.ExitToolStripMenuItem_Click;
            btn_Donate.Click += donate.Btn_Donate_Click;
        }

        private void ClipChange_ClipboardUpdate(object sender, EventArgs e)
        {
            string tempText = Clipboard.GetText();
            if (!string.IsNullOrWhiteSpace(tempText) && tempText != CurrentlyCopiedItem)
            {
                CurrentlyCopiedItem = tempText;
                virtualClipboard.LastCopied = tempText;
                virtualClipboard.History += ($"{CurrentlyCopiedItem}\n");

                if (Properties.Settings.Default.WriteInRealTime)
                {
                    file.WriteToFile(virtualClipboard);
                }

                if (Properties.Settings.Default.NotifyCopy)
                {
                    notificationIcon.BalloonTipText = resManager.GetString("Notif_ItemCopied");
                    notificationIcon.BalloonTipTitle = resManager.GetString("Notif_Title_ItemCopied");
                    notificationIcon.ShowBalloonTip(Properties.Settings.Default.NotificationTimeout);
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                FirstTimeUseMinimize();
            }
            else Show();
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Focus();
        }

        private void NotificationIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestoreToolStripMenuItem_Click(sender, e);
        }

        private void InitSettings()
        {
            if (Properties.Settings.Default.AdminCheck)
            {
                if (!autoRunApplication.RunChecks().Equals(0))
                {
                    MessageBox.Show(Constants.Message_AdminErr, Constants.Title_Message_AdminErr,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            file.FilePath = Properties.Settings.Default.SaveFileLocation;
            if (Properties.Settings.Default.UseWhiteIcon)
            {
                notificationIcon.Icon = Constants.whiteIcon;
            }
            else
            {
                notificationIcon.Icon = Constants.darkIcon;
            }

            if (Properties.Settings.Default.AutoClearClip)
            {
                timeToClear = new TimeCalculate();
                timeToClear.CalculateToSeconds(Properties.Settings.Default.AutoClsTime,
                    Properties.Settings.Default.AutoClsType);
                timerEmptyClipboard.Start();
            }
            else
            {
                timerEmptyClipboard.Stop();
                timerEmptyClipboard.Dispose();
            }
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.MinimizeOnClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                FirstTimeUseMinimize();
            }
            else
            {
                Properties.Settings.Default.Save();
                if (!Properties.Settings.Default.WriteInRealTime)
                {
                    file.WriteBeforeClosing(virtualClipboard);
                }
                Application.Exit();
            }
        }

        private void Btn_options_Click(object sender, EventArgs e)
        {
            Form optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
            InitSettings();
            SetLanguage();
        }

        private void TimerEmptyClipboard_Tick(object sender, EventArgs e)
        {
            if (timeToClear.TargetDate <= DateTime.Now)
            {
                clipboardAction.ClearHistory_Click(sender, e);
                InitSettings();
            }
        }

        private void FirstTimeUseMinimize()
        {
            if (Properties.Settings.Default.FirstTimeUse)
            {
                notificationIcon.ShowBalloonTip(Properties.Settings.Default.NotificationTimeout);
                Properties.Settings.Default.FirstTimeUse = false;
            }
        }

        private void SetLanguage()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.lang_{Properties.Settings.Default.CurrentLanguage}",
                Assembly.GetExecutingAssembly());
            Text = resManager.GetString("Main_Title");
            groupBox_copiedItems.Text = resManager.GetString("GroupBox_CopiedItems");
            groupBox_Actions.Text = resManager.GetString("GroupBox_Actions");
            btn_EmptyClipboard.Text = resManager.GetString("Button_EmptyClipboard");
            btn_ClearHistory.Text = resManager.GetString("Button_EmptyHistory");
            btn_options.Text = resManager.GetString("Button_MoreOptions");
            restoreToolStripMenuItem.Text = resManager.GetString("Menu_Restore");
            emptyClipboardToolStripMenuItem.Text = resManager.GetString("Menu_EmptyClipboard");
            emptyHistoryToolStripMenuItem.Text = resManager.GetString("Menu_EmptyHistory");
            exitToolStripMenuItem.Text = resManager.GetString("Menu_Exit");
            notificationIcon.Text = resManager.GetString("Main_Title");
            notificationIcon.BalloonTipText = resManager.GetString("Notif_AppStillRunning");
            notificationIcon.BalloonTipTitle = resManager.GetString("Notif_Title_AppStillRunning");
        }

    }

    
}
