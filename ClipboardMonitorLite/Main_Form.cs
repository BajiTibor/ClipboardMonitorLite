using System;
using System.Windows.Forms;
using System.IO;

namespace ClipboardMonitorLite
{
    public partial class MainForm : Form
    {
        private TimeCalculate timeToClear;
        private string CurrentlyCopiedItem { get; set; }
        private VirtualClipboard @virtual;
        private ClipboardAction clipboardAction;
        private FileOperation file;
        private StartWithWindows autoRunApplication;
        public MainForm()
        {
            autoRunApplication = new StartWithWindows();
            @virtual = new VirtualClipboard();
            clipboardAction = new ClipboardAction(@virtual);
            if (Properties.Settings.Default.SaveFileLocation.Equals(string.Empty))
            {
                Properties.Settings.Default.SaveFileLocation = Directory.GetCurrentDirectory() 
                    + $"/{file.Format()}";
            }
            file = new FileOperation(Properties.Settings.Default.SaveFileLocation);
            InitializeComponent();
            InitSettings();

            

            CopiedItemBox.DataBindings.Add("Text", @virtual, "History",
                true, DataSourceUpdateMode.OnPropertyChanged);

            
            ClipChange.ClipboardUpdate += ClipChange_ClipboardUpdate;
            btn_EmptyClipboard.Click += clipboardAction.ClearClip_Click;
            btn_ClearHistory.Click += clipboardAction.ClearHistory_Click;
            emptyClipboardToolStripMenuItem.Click += clipboardAction.ClearClip_Click;
            emptyHistoryToolStripMenuItem.Click += clipboardAction.ClearHistory_Click;
        }

        private void ClipChange_ClipboardUpdate(object sender, EventArgs e)
        {
            string tempText = Clipboard.GetText();
            if (!string.IsNullOrWhiteSpace(tempText) && tempText != CurrentlyCopiedItem)
            {
                CurrentlyCopiedItem = tempText;
                @virtual.LastCopied = tempText;
                @virtual.History += ($"{CurrentlyCopiedItem}\n");

                if (Properties.Settings.Default.WriteInRealTime)
                {
                    file.WriteToFile(@virtual);
                }

                if (Properties.Settings.Default.NotifyCopy)
                {
                    notificationIcon.BalloonTipText = Constants.clipChange;
                    notificationIcon.BalloonTipTitle = Constants.clipChangeTitle;
                    notificationIcon.ShowBalloonTip(Properties.Settings.Default.NotificationTimeout);
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                if (Properties.Settings.Default.FirstTimeUse)
                {
                    notificationIcon.ShowBalloonTip(Properties.Settings.Default.NotificationTimeout);
                    Properties.Settings.Default.FirstTimeUse = false;
                }
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitSettings()
        {
            autoRunApplication.RunChecks();
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
            Properties.Settings.Default.Save();
            if (!Properties.Settings.Default.WriteInRealTime)
            {
                file.WriteBeforeClosing(@virtual);
            }
            Application.Exit();
        }

        private void Btn_options_Click(object sender, EventArgs e)
        {
            Form optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
            InitSettings();
        }

        private void TimerEmptyClipboard_Tick(object sender, EventArgs e)
        {
            if (timeToClear.TargetDate <= DateTime.Now)
            {
                clipboardAction.ClearHistory_Click(sender, e);
                InitSettings();
            }
        }
    }
}
