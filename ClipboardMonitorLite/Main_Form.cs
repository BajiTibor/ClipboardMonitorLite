using System;
using System.Windows.Forms;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.FormControls;
using ClipboardMonitorLite.Languages;
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
        SetLanguageOnForm _langChange;
        public MainForm()
        {
            _settingsHandler = new HandleSettings();
            _clipManager = new ClipboardManager();
            InitializeComponent();
            _file = new CreateJsonFile();
            _settings = _settingsHandler.LoadSettingsFile();
            _langChange = new SetLanguageOnForm();
            _buttonActions = new ButtonActions(_clipManager, notificationIcon, this, _settings);
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
        }

        private void Btn_MoreOptions_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm(_settings);
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