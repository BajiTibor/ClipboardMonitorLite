using System;
using SettingsLib;
using CloudConnectionLib;
using System.Windows.Forms;
using ClipboardMonitorLite.Cloud;
using CloudConnectionLib.Messages;
using ClipboardMonitorLite.FormControls;
using ClipboardMonitorLite.FileOperations;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.Languages.LanguageControl;

namespace ClipboardMonitorLite
{
    public partial class MainForm : Form
    {
        private Settings _settings;
        private FormEvents _formEvents;
        private OnlineSettings _onlineSettings;
        private SignalRMessage _inboundMessage;
        private LanguageOnForm _languageOnForm;
        private SignalRMessage _outgoingMessage;
        private SettingsHandler _settingsHandler;
        private CheckStaticConnectionState _checkConnection;
        private LaunchOnStartup _startWithWindows;
        private WriteHistoryFile _writeHistoryFile;
        private ClipboardManager _clipboardManager;
        private CloudInteractions _cloudInteractions;

        public MainForm()
        {
            InitializeComponent();
            _settingsHandler = new SettingsHandler();
            _settings = _settingsHandler.LoadSettingsFile() as Settings;
            _onlineSettings = _settingsHandler.LoadSettingsFile(true) as OnlineSettings;
            _inboundMessage = new SignalRMessage();
            _outgoingMessage = new SignalRMessage();
            _clipboardManager = new ClipboardManager(_inboundMessage, _outgoingMessage, _settings);
            _cloudInteractions = new CloudInteractions(_inboundMessage, _outgoingMessage, _settings, _onlineSettings);
            _writeHistoryFile = new WriteHistoryFile(_clipboardManager, _settings);
            _languageOnForm = new LanguageOnForm();
            _formEvents = new FormEvents(_clipboardManager, notificationIcon, this, _settings, _writeHistoryFile, _onlineSettings);
            _startWithWindows = new LaunchOnStartup(_settings);
            _checkConnection = new CheckStaticConnectionState(Label_Connection_DONOTMODIFY, timer_checkConnection);
            EnumSetLang();
            BindProperties();
            BindButtonActions();
        }

        private void BindProperties()
        {
            CopiedItemBox.DataBindings.Add("Text", _clipboardManager, "ClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Btn_Donate.DataBindings.Add("Visible", _settings, "ShowDonation",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindButtonActions()
        {
            FormClosing += _formEvents.FormClosing;
            Btn_Donate.Click += _formEvents.DonationClick;
            CopiedItemBox.LinkClicked += _formEvents.LinkClicked;
            Btn_EmptyHistory.Click += _formEvents.ClearHistoryClick;
            Btn_EmptyClipboard.Click += _formEvents.ClearClipboardClick;
            notificationIcon.DoubleClick += _formEvents.RestoreWindowClick;
            exitToolStripMenuItem.Click += _formEvents.ExitApplicationClick;
            restoreToolStripMenuItem.Click += _formEvents.RestoreWindowClick;
            emptyHistoryToolStripMenuItem.Click += _formEvents.ClearHistoryClick;
            emptyClipboardToolStripMenuItem.Click += _formEvents.ClearClipboardClick;
        }
        private void Btn_MoreOptions_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm(_settings, _onlineSettings, _formEvents);
            form.ShowDialog();
            form.Dispose();
            _settingsHandler.CreateFile(_settings);
            _settingsHandler.CreateFile(_onlineSettings);
            _languageOnForm.SetLang(_settings, this);
        }

        private void EnumSetLang()
        {
            _languageOnForm.SetLang(_settings, this);
        }
    }
}