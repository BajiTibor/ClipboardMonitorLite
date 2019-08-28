using System;
using System.Reflection;
using System.Windows.Forms;
using ClipboardMonitorLite.Languages;
using ClipboardMonitorLite.FormControls;
using ClipboardMonitorLite.SettingsManager;

namespace ClipboardMonitorLite
{
    public partial class OptionsForm : Form
    {
        private Settings _settings;
        private ButtonActions _buttonActions;
        private SetLanguageOnForm _langChange;
        public OptionsForm(Settings settings, ButtonActions buttonActions)
        {
            _buttonActions = buttonActions;
            _langChange = new SetLanguageOnForm();
            _settings = settings;
            InitializeComponent();
            InitializeLanguage();
            InitializeProperties();
            BindButtonEvents();
        }

        private void BindButtonEvents()
        {
            Btn_Browse.Click += _buttonActions.OpenFileBrowserClick;
        }

        private void InitializeProperties()
        {
            Check_UseWhiteIcon.DataBindings.Add("Checked", _settings, "UsingWhiteTrayIcon",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_NotifyOfCopy.DataBindings.Add("Checked", _settings, "NotifyClipboardChange",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_SaveToFile.DataBindings.Add("Checked", _settings, "SaveClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_AutoClearClipboard.DataBindings.Add("Checked", _settings, "AutoClearClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_clearAfter.DataBindings.Add("Value", _settings, "ClearBetween",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_StartMinimized.DataBindings.Add("Checked", _settings, "StartMinimized",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Radio_Minimize.DataBindings.Add("Checked", _settings, "MinimizeOnClose", // MinimizeOnClose
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_ShowDonation.DataBindings.Add("Checked", _settings, "ShowDonation",
                true, DataSourceUpdateMode.OnPropertyChanged);

            combo_lang.DataBindings.Add("SelectedIndex", _settings, "CurrentlySelectedLanguage",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txt_FileLocation.DataBindings.Add("Text", _settings, "HistoryFileLocation",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_WriteInRealTime.DataBindings.Add("Checked", _settings, "WriteInRealTime",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_OpenWithWin.DataBindings.Add("Checked", _settings, "StartWithWindows",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_clearAfter.DataBindings.Add("Enabled", _settings, "AutoClearClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txt_FileLocation.DataBindings.Add("Enabled", _settings, "SaveClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Btn_Browse.DataBindings.Add("Enabled", _settings, "SaveClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_WriteInRealTime.DataBindings.Add("Enabled", _settings, "SaveClipboardHistory",
                true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void Combo_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.CurrentlySelectedLanguage = combo_lang.SelectedIndex;
            InitializeLanguage();
        }

        private void InitializeLanguage()
        {
            _langChange.SetLang(_settings, this);
            Label_Version.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
