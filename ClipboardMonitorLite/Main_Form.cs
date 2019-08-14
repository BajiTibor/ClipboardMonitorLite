using System;
using System.Diagnostics;
using System.Windows.Forms;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.FormControls;
using ClipboardMonitorLite.SettingsManager;

namespace ClipboardMonitorLite
{
    public partial class MainForm : Form
    {
        ClipboardManager _clipManager;
        ButtonActions _buttonActions;
        Settings _settings;
        CreateJsonFile _file;
        HandleSettings _settingsHandler;
        public MainForm()
        {
            _settingsHandler = new HandleSettings();
            _clipManager = new ClipboardManager();
            InitializeComponent();
            _buttonActions = new ButtonActions(_clipManager, notificationIcon);
            _settings = new Settings();
            _file = new CreateJsonFile();

            _settings = _settingsHandler.LoadSettingsFile();

            BindProperties();
            BindButtonActions();
        }

        private void BindProperties()
        {
            CopiedItemBox.DataBindings.Add("Text", _clipManager, "ClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindButtonActions()
        {
            Resize += _buttonActions.HideWindowClick;
            restoreToolStripMenuItem.Click += _buttonActions.RestoreWindowClick;
            Btn_EmptyHistory.Click += _buttonActions.ClearHistoryClick;
            Btn_EmptyClipboard.Click += _buttonActions.ClearClipboardClick;
            btn_Donate.Click += _buttonActions.DonationClick;
            emptyHistoryToolStripMenuItem.Click += _buttonActions.ClearHistoryClick;
            emptyClipboardToolStripMenuItem.Click += _buttonActions.ClearClipboardClick;
            exitToolStripMenuItem.Click += _buttonActions.ExitApplicationClick;
            notificationIcon.DoubleClick += _buttonActions.RestoreWindowClick;
        }

        private void Btn_MoreOptions_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm(_settings);
            form.ShowDialog();
            form.Dispose();
            _file.CreateFile(_settings);
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