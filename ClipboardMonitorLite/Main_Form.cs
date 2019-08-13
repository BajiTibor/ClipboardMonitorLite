using System.Windows.Forms;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.FormControls;
using ClipboardMonitorLite.SettingsManager;

namespace ClipboardMonitorLite
{
    public partial class MainForm : Form
    {
        ClipboardManager ClipManager;
        ButtonActions ButtonActions;
        Settings Settings;
        public MainForm()
        {
            ClipManager = new ClipboardManager();
            InitializeComponent();
            ButtonActions = new ButtonActions(ClipManager, notificationIcon);
            Settings = new Settings();
            Settings.SettingsFileLocation();
            BindProperties();
            BindButtonActions();
        }

        private void BindProperties()
        {
            CopiedItemBox.DataBindings.Add("Text", ClipManager, "ClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindButtonActions()
        {
            Resize += ButtonActions.HideWindowClick;
            restoreToolStripMenuItem.Click += ButtonActions.RestoreWindowClick;
            Btn_EmptyHistory.Click += ButtonActions.ClearHistoryClick;
            Btn_EmptyClipboard.Click += ButtonActions.ClearClipboardClick;
            btn_Donate.Click += ButtonActions.DonationClick;
            emptyHistoryToolStripMenuItem.Click += ButtonActions.ClearHistoryClick;
            emptyClipboardToolStripMenuItem.Click += ButtonActions.ClearClipboardClick;
            exitToolStripMenuItem.Click += ButtonActions.ExitApplicationClick;
            notificationIcon.DoubleClick += ButtonActions.RestoreWindowClick;
        }









        /*
        private ClipboardMonitorLite.ChangeControl changeControl;
        private FormControls controls;
        private FormActions formActions;
        private TimeCalculate timeToClear;
        private string CurrentlyCopiedItem { get; set; }
        private VirtualClipboard virtualClipboard;
        //private ClipboardAction clipboardAction;
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

            WindowState = UserSettings.CustomSettings.Default.FormStartState;
            
        }
        
        private void BindProperties()
        {
            CopiedItemBox.DataBindings.Add("Text", virtualClipboard, "History",
                true, DataSourceUpdateMode.OnPropertyChanged);

            btn_Donate.DataBindings.Add("Visible", UserSettings.CustomSettings.Default, "ShowDonateBtn",
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
            Resize += formActions.ResizeFormObject;
            restoreToolStripMenuItem.Click += formActions.RestoreFormObject;
            notificationIcon.MouseDoubleClick += formActions.RestoreFormObject;
            FormClosing += formActions.FormClosing;
            
        }

        private void InitializeObjects()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[UserSettings.CustomSettings.Default.CurrentLang]}",
                Assembly.GetExecutingAssembly());
            
            controls = new FormControls();
            donate = new Donate();
            virtualClipboard = new VirtualClipboard();
            //clipboardAction = new ClipboardAction(virtualClipboard);
            changeControl = new ClipboardMonitorLite.ChangeControl();

            file = new FileOperation("");
            if (UserSettings.CustomSettings.Default.SaveFileLocation.Equals(string.Empty))
            {
                UserSettings.CustomSettings.Default.SaveFileLocation = Directory.GetCurrentDirectory()
                    + $"/{file.Format()}";
            }
            file.FilePath = UserSettings.CustomSettings.Default.SaveFileLocation;

            formActions = new FormActions(notificationIcon, virtualClipboard, resManager, file);
            
        }
        
        private void ClipChange_ClipboardUpdate(object sender, EventArgs e)
        {
            string tempText = Clipboard.GetText();
            if (!string.IsNullOrWhiteSpace(tempText) && tempText != CurrentlyCopiedItem)
            {
                CurrentlyCopiedItem = tempText;
                virtualClipboard.LastCopied = tempText;
                virtualClipboard.History += ($"{CurrentlyCopiedItem}\n");

                if (UserSettings.CustomSettings.Default.SaveToFile)
                    file.WriteToFile(virtualClipboard);
                

                if (UserSettings.CustomSettings.Default.NotifyCopy)
                {
                    changeControl.ChangeText(notificationIcon); 
                    
                    notificationIcon.BalloonTipText = resManager.GetString("Notif_ItemCopied");
                    notificationIcon.BalloonTipTitle = resManager.GetString("Notif_Title_ItemCopied");
                    notificationIcon.ShowBalloonTip(4);
                    
                }
            }
        }

        private void InitSettings()
        {
            file.FilePath = UserSettings.CustomSettings.Default.SaveFileLocation;

            formActions.SetTaskbarIcon();

            if (!UserSettings.CustomSettings.Default.AutoClsTime.Equals(0))
            {
                timeToClear = new TimeCalculate();
                timeToClear.CalculateToSeconds(UserSettings.CustomSettings.Default.AutoClsTime);
                timerEmptyClipboard.Start();
            }
            else
            {
                timerEmptyClipboard.Stop();
                timerEmptyClipboard.Dispose();
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

        

        private void EnumSetLang()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[UserSettings.CustomSettings.Default.CurrentLang]}",
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
    */

    }
}