using ClipboardMonitorLite.UserSettings;
using System;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace ClipboardLibrary
{
    public partial class OptionsForm : Form
    {
        private Updates updates;
        private ResourceManager resManager;
        private FormControls controls;
        public OptionsForm()
        {
            InitializeObjects();
            InitializeComponent();
            InitializeLanguage();
            InitializeProperties();
            BindButtonEvents();
        }

        private void BindButtonEvents()
        {
            Btn_CheckForUpdates.Click += updates.Btn_checkForUpdates_Click;
        }

        private void InitializeObjects()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[CustomSettings.Default.CurrentLang]}",
                Assembly.GetExecutingAssembly());
            updates = new Updates();
            controls = new FormControls();
        }

        private void InitializeProperties()
        {
            Check_UseWhiteIcon.DataBindings.Add("Checked", CustomSettings.Default, "UseWhiteIcon",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_NotifyOfCopy.DataBindings.Add("Checked", CustomSettings.Default, "NotifyCopy",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_SaveToFile.DataBindings.Add("Checked", CustomSettings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_AutoClearClipboard.DataBindings.Add("Checked", CustomSettings.Default, "AutoClearClip",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_clearAfter.DataBindings.Add("Value", CustomSettings.Default, "AutoClsTime",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txt_FileLocation.DataBindings.Add("Text", CustomSettings.Default, "SaveFileLocation",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_WriteInRealTime.DataBindings.Add("Checked", CustomSettings.Default, "RealTimeWrite",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Label_WriteRealTimeInfo.DataBindings.Add("Visible", CustomSettings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txt_FileLocation.DataBindings.Add("Enabled", CustomSettings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Btn_Browse.DataBindings.Add("Enabled", CustomSettings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_WriteInRealTime.DataBindings.Add("Enabled", CustomSettings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_clearAfter.DataBindings.Add("Enabled", CustomSettings.Default, "AutoClearClip",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Radio_Minimize.DataBindings.Add("Checked", CustomSettings.Default, "MinimizeOnClose",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_ShowDonation.DataBindings.Add("Checked", CustomSettings.Default, "ShowDonateBtn",
                true, DataSourceUpdateMode.OnPropertyChanged);

            combo_lang.DataBindings.Add("SelectedIndex", CustomSettings.Default, "CurrentLang",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Btn_browse_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = resManager.GetString("File_TextFile");
            saveFileDialog.Title = resManager.GetString("SaveAsTextFile");
            saveFileDialog.ShowDialog();

            if (!saveFileDialog.FileName.Equals(string.Empty))
            {
                CustomSettings.Default.SaveFileLocation = saveFileDialog.FileName;
            }
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            CustomSettings.Default.Save();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void Radio_MinimizeOnClose_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_StartMinimized.Checked)
            {
                CustomSettings.Default.FormStartState = FormWindowState.Minimized;
            }
            else
            {
                CustomSettings.Default.FormStartState = FormWindowState.Normal;
            }
        }

        private void Check_HideDonate_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomSettings.Default.FirstTimeHiding)
            {
                MessageBox.Show(resManager.GetString("MsgBox_DonateHide"), resManager.GetString("MsgBox_Title_DonateHide"),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomSettings.Default.FirstTimeHiding = false;
            }
        }

        private void Combo_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomSettings.Default.CurrentLang = combo_lang.SelectedIndex;
            InitializeLanguage();
        }

        private void InitializeLanguage()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[CustomSettings.Default.CurrentLang]}",
                Assembly.GetExecutingAssembly());

            foreach (var item in controls.GetAllControl(this))
            {
                if (!(item is ComboBox) && !(item.Name.Contains("DONOTMODIFY") && !(item is RichTextBox) && !(item is TextBox)))
                {
                    item.Text = resManager.GetString(item.Name);
                }
            }
            Text = resManager.GetString("Options_Title");
            Label_Version.Text += updates.GetVersionNumber();
        }
    }
}
