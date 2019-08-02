using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public partial class OptionsForm : Form
    {
        private Updates updates;
        private ResourceManager resManager;
        private FormControls controls;
        public OptionsForm()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.lang_{LanguageCode.LanguageList[Properties.Settings.Default.CurrentLanguage]}",
                Assembly.GetExecutingAssembly());
            updates = new Updates();
            controls = new FormControls();
            InitializeComponent();
            //BindAllProperties();
            EnumSetLang();
            BindAllProperties();
            if (!Check_OpenWithWin.Enabled)
                Label_NoAdminRights.Visible = true;

            

            Btn_CheckForUpdates.Click += updates.Btn_checkForUpdates_Click;
        }

        private void BindAllProperties()
        {
            Check_UseWhiteIcon.DataBindings.Add("Checked", Properties.Settings.Default, "UseWhiteIcon",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_NotifyOfCopy.DataBindings.Add("Checked", Properties.Settings.Default, "NotifyCopy",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_notifTimeout.DataBindings.Add("Value", Properties.Settings.Default, "NotificationTimeout",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_SaveToFile.DataBindings.Add("Checked", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_AutoClearClipboard.DataBindings.Add("Checked", Properties.Settings.Default, "AutoClearClip",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_clearAfter.DataBindings.Add("Value", Properties.Settings.Default, "AutoClsTime",
                true, DataSourceUpdateMode.OnPropertyChanged);

            combo_timeFormat.DataBindings.Add("SelectedIndex", Properties.Settings.Default, "AutoClsTimeType",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_OpenWithWin.DataBindings.Add("Checked", Properties.Settings.Default, "OpenWithWin",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txt_FileLocation.DataBindings.Add("Text", Properties.Settings.Default, "SaveFileLocation",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Radio_Append.DataBindings.Add("Checked", Properties.Settings.Default, "AppendFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_WriteInRealTime.DataBindings.Add("Checked", Properties.Settings.Default, "WriteInRealTime",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_notifTimeout.DataBindings.Add("Enabled", Properties.Settings.Default, "NotifyCopy",
                true, DataSourceUpdateMode.OnPropertyChanged);

            /*
            GroupBox_SaveToFileSettings.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);
                */

            Label_WriteRealTimeInfo.DataBindings.Add("Visible", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txt_FileLocation.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Btn_Browse.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Radio_Append.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Radio_EmptyAndReplace.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_WriteInRealTime.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_clearAfter.DataBindings.Add("Enabled", Properties.Settings.Default, "AutoClearClip",
                true, DataSourceUpdateMode.OnPropertyChanged);

            combo_timeFormat.DataBindings.Add("Enabled", Properties.Settings.Default, "AutoClearClip",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_OpenWithWin.DataBindings.Add("Enabled", Properties.Settings.Default, "CanRestartAsAdmin",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_StartMinimized.DataBindings.Add("Enabled", Properties.Settings.Default, "OpenWithWin",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Radio_Minimize.DataBindings.Add("Checked", Properties.Settings.Default, "MinimizeOnClose",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_ShowDonation.DataBindings.Add("Checked", Properties.Settings.Default, "DisplayDonate",
                true, DataSourceUpdateMode.OnPropertyChanged);

            Check_UpdateOnStartup.DataBindings.Add("Checked", Properties.Settings.Default, "AutoCheckUpdates",
                true, DataSourceUpdateMode.OnPropertyChanged);

            combo_lang.DataBindings.Add("SelectedIndex", Properties.Settings.Default, "CurrentLanguage",
                true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void Btn_browse_Click(object sender, EventArgs e)
        {

            saveFileDialog.Filter = resManager.GetString("File_TextFile");
            saveFileDialog.Title = resManager.GetString("SaveAsTextFile");
            saveFileDialog.ShowDialog();

            if (!saveFileDialog.FileName.Equals(string.Empty))
            {
                Properties.Settings.Default.SaveFileLocation = saveFileDialog.FileName;
            }
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
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
                Properties.Settings.Default.FormStartState = FormWindowState.Minimized;
            }
            else
            {
                Properties.Settings.Default.FormStartState = FormWindowState.Normal;
            }
        }

        private void Combo_timeFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_timeFormat.SelectedIndex.Equals((int)Time.Format.Seconds))
            {
                numeric_clearAfter.Value = 30;
                numeric_clearAfter.Minimum = 30;
                combo_timeFormat.SelectedIndex = (int)Time.Format.Seconds;
            }
            else
            {
                numeric_clearAfter.Minimum = 1;
            }
        }

        private void Check_HideDonate_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstTimeHiding)
            {
                MessageBox.Show(resManager.GetString("MsgBox_DonateHide"), resManager.GetString("MsgBox_Title_DonateHide"),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.FirstTimeHiding = false;
            }
        }

        private void Combo_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentLanguage = combo_lang.SelectedIndex;
            EnumSetLang();
        }

        private void EnumSetLang()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.lang_{LanguageCode.LanguageList[Properties.Settings.Default.CurrentLanguage]}",
                Assembly.GetExecutingAssembly());

            foreach (var item in controls.AllControl(this))
            {
                if (!(item is ComboBox) && !(item.Name.Contains("DONOTMODIFY") && !(item is RichTextBox) && !(item is TextBox)))
                {
                    item.Text = resManager.GetString(item.Name);
                }
            }
            Text = resManager.GetString("Options_Title");
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Label_Version.Text += fvi.FileVersion;
            
        }
    }
}
