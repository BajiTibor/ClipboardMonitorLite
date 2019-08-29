using System;
using System.Windows.Forms;
using ClipboardMonitorLite.Languages;
using ClipboardMonitorLite.FormControls;
using ClipboardMonitorLite.FileOperations;
using ClipboardMonitorLite.SettingsManager;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.Cloud;

namespace ClipboardMonitorLite
{
    public partial class MainForm : Form
    {
        Settings _settings;
        CreateJsonFile _file;
        SaveHistory _historyFile;
        ButtonActions _buttonActions;
        SetLanguageOnForm _langChange;
        ClipboardManager _clipManager;
        HandleSettings _settingsHandler;
        WinStartup _startup;
        ClipMessage _message;
        
        public MainForm()
        {
            _message = new ClipMessage();
            _settingsHandler = new HandleSettings();
            _clipManager = new ClipboardManager(_message);
            InitializeComponent();
            _file = new CreateJsonFile();
            _settings = _settingsHandler.LoadSettingsFile();
            _historyFile = new SaveHistory(_clipManager, _settings);
            _langChange = new SetLanguageOnForm();
            _buttonActions = new ButtonActions(_clipManager, notificationIcon, this, _settings, _historyFile);
            _startup = new WinStartup(_settings);
            EnumSetLang();
            BindProperties();
            BindButtonActions();
        }

        private void BindProperties()
        {
            CopiedItemBox.DataBindings.Add("Text", _clipManager, "ClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);
            btn_Donate.DataBindings.Add("Visible", _settings, "ShowDonation",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindButtonActions()
        {
            restoreToolStripMenuItem.Click += _buttonActions.RestoreWindowClick;
            Btn_EmptyHistory.Click += _buttonActions.ClearHistoryClick;
            Btn_EmptyClipboard.Click += _buttonActions.ClearClipboardClick;
            btn_Donate.Click += _buttonActions.DonationClick;
            emptyHistoryToolStripMenuItem.Click += _buttonActions.ClearHistoryClick;
            emptyClipboardToolStripMenuItem.Click += _buttonActions.ClearClipboardClick;
            exitToolStripMenuItem.Click += _buttonActions.ExitApplicationClick;
            notificationIcon.DoubleClick += _buttonActions.RestoreWindowClick;
            FormClosing += _buttonActions.FormClosing;
            CopiedItemBox.LinkClicked += _buttonActions.LinkClicked;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            _clipManager.ChangeTextOnClip("Blah");
        }
    }
}