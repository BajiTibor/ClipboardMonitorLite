using System;
using System.Windows.Forms;
using ClipboardMonitorLite.Cloud;
using ClipboardMonitorLite.Languages;
using ClipboardMonitorLite.FormControls;
using ClipboardMonitorLite.FileOperations;
using ClipboardMonitorLite.SettingsManager;
using ClipboardMonitorLite.ClipboardActions;

namespace ClipboardMonitorLite
{
    public partial class MainForm : Form
    {
        private Settings _settings;
        private WinStartup _startup;
        private CreateJsonFile _file;
        private ClipMessage _message;
        private SaveHistory _historyFile;
        private FormEvents _buttonActions;
        private SetLanguageOnForm _langChange;
        private ClipboardManager _clipManager;
        private SettingsHandler _settingsHandler;
        
        public MainForm()
        {
            _message = new ClipMessage();
            _settingsHandler = new SettingsManager.SettingsHandler();
            _clipManager = new ClipboardManager(_message);
            InitializeComponent();
            _file = new CreateJsonFile();
            _settings = _settingsHandler.LoadSettingsFile();
            _historyFile = new SaveHistory(_clipManager, _settings);
            _langChange = new SetLanguageOnForm();
            _buttonActions = new FormEvents(_clipManager, notificationIcon, this, _settings, _historyFile);
            _startup = new WinStartup(_settings);
            EnumSetLang();
            BindProperties();
            BindButtonActions();
        }

        private void BindProperties()
        {
            CopiedItemBox.DataBindings.Add("Text", _clipManager, "ClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);
            Btn_Donate.DataBindings.Add("Visible", _settings, "ShowDonation",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindButtonActions()
        {
            FormClosing += _buttonActions.FormClosing;
            Btn_Donate.Click += _buttonActions.DonationClick;
            CopiedItemBox.LinkClicked += _buttonActions.LinkClicked;
            Btn_EmptyHistory.Click += _buttonActions.ClearHistoryClick;
            Btn_EmptyClipboard.Click += _buttonActions.ClearClipboardClick;
            notificationIcon.DoubleClick += _buttonActions.RestoreWindowClick;
            exitToolStripMenuItem.Click += _buttonActions.ExitApplicationClick;
            restoreToolStripMenuItem.Click += _buttonActions.RestoreWindowClick;
            emptyHistoryToolStripMenuItem.Click += _buttonActions.ClearHistoryClick;
            emptyClipboardToolStripMenuItem.Click += _buttonActions.ClearClipboardClick;
        }
        private void Btn_MoreOptions_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm(_settings, _buttonActions);
            form.ShowDialog();
            form.Dispose();
            _file.CreateFile(_settings);
            _langChange.SetLang(_settings, this);
        }

        private void EnumSetLang()
        {
            _langChange.SetLang(_settings, this);
        }
    }
}