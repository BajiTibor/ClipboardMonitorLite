using System;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Reflection;
using ClipboardMonitorLite.UserSettings;

namespace ClipboardLibrary
{
    public partial class MainForm : Form
    {
        private FormControls controls;
        private FormActions formActions;
        private TimeCalculate timeToClear;
        private string CurrentlyCopiedItem { get; set; }
        private VirtualClipboard virtualClipboard;
        private ClipboardAction clipboardAction;
        private FileOperation file;
        private Donate donate;
        private ResourceManager resManager;
        public MainForm()
        {
            InitializeObjects();
            InitializeComponent();
            InitSettings();
            EnumSetLang();
            BindProperties();
            BindEvents();

            WindowState = CustomSettings.Default.FormStartState;
        }

        private void BindProperties()
        {
            CopiedItemBox.DataBindings.Add("Text", virtualClipboard, "History",
                true, DataSourceUpdateMode.OnPropertyChanged);

            btn_Donate.DataBindings.Add("Visible", CustomSettings.Default, "ShowDonateBtn",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindEvents()
        {
            ClipChange.ClipboardUpdate += ClipChange_ClipboardUpdate;
            Btn_EmptyClipboard.Click += clipboardAction.ClearClip_Click;
            Btn_EmptyHistory.Click += clipboardAction.ClearHistory_Click;
            emptyClipboardToolStripMenuItem.Click += clipboardAction.ClearClip_Click;
            emptyHistoryToolStripMenuItem.Click += clipboardAction.ClearHistory_Click;
            exitToolStripMenuItem.Click += formActions.ExitToolStripMenuItem_Click;
            btn_Donate.Click += donate.Btn_Donate_Click;
        }

        private void InitializeObjects()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[CustomSettings.Default.CurrentLang]}",
                Assembly.GetExecutingAssembly());
            controls = new FormControls();
            donate = new Donate();
            formActions = new FormActions();
            virtualClipboard = new VirtualClipboard();
            clipboardAction = new ClipboardAction(virtualClipboard);

            file = new FileOperation("");
            if (CustomSettings.Default.SaveFileLocation.Equals(string.Empty))
            {
                CustomSettings.Default.SaveFileLocation = Directory.GetCurrentDirectory()
                    + $"/{file.Format()}";
            }
            file.FilePath = CustomSettings.Default.SaveFileLocation;
        }

        private void ClipChange_ClipboardUpdate(object sender, EventArgs e)
        {
            string tempText = Clipboard.GetText();
            if (!string.IsNullOrWhiteSpace(tempText) && tempText != CurrentlyCopiedItem)
            {
                CurrentlyCopiedItem = tempText;
                virtualClipboard.LastCopied = tempText;
                virtualClipboard.History += ($"{CurrentlyCopiedItem}\n");

                if (CustomSettings.Default.SaveToFile)
                    file.WriteToFile(virtualClipboard);
                

                if (CustomSettings.Default.NotifyCopy)
                {
                    notificationIcon.BalloonTipText = resManager.GetString("Notif_ItemCopied");
                    notificationIcon.BalloonTipTitle = resManager.GetString("Notif_Title_ItemCopied");
                    notificationIcon.ShowBalloonTip(4);
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
           
            file.FilePath = CustomSettings.Default.SaveFileLocation;

            if (CustomSettings.Default.UseWhiteIcon)
                notificationIcon.Icon = Constants.whiteIcon;
            else
                notificationIcon.Icon = Constants.darkIcon;

            if (!CustomSettings.Default.AutoClsTime.Equals(0))
            {
                timeToClear = new TimeCalculate();
                timeToClear.CalculateToSeconds(CustomSettings.Default.AutoClsTime);
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
            if (CustomSettings.Default.MinimizeOnClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                FirstTimeUseMinimize();
            }
            else
            {
                CustomSettings.Default.Save();
                if (!CustomSettings.Default.RealTimeWrite)
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
            optionsForm.Dispose();
            InitSettings();
            EnumSetLang();
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
            if (CustomSettings.Default.FirstTimeUse)
            {
                notificationIcon.BalloonTipText = resManager.GetString("Notif_AppStillRunning");
                notificationIcon.BalloonTipTitle = resManager.GetString("Notif_Title_AppStillRunning");
                notificationIcon.ShowBalloonTip(4);
                CustomSettings.Default.FirstTimeUse = false;
            }
        }

        private void EnumSetLang()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[CustomSettings.Default.CurrentLang]}",
                Assembly.GetExecutingAssembly());

            foreach (var item in controls.GetAllControl(this))
            {
                if (!(item is ComboBox) && !(item.Name.Contains("DONOTMODIFY") && !(item is RichTextBox)))
                {
                    item.Text = resManager.GetString(item.Name);
                }
            }
            Text = resManager.GetString("Main_Title");
        }
    }
}
