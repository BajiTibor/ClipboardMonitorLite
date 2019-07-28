using System;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public partial class OptionsForm : Form
    {
        private Updates updates;
        private ResourceManager resManager;
        public OptionsForm()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.lang_{Properties.Settings.Default.CurrentLanguage}",
                Assembly.GetExecutingAssembly());
            updates = new Updates();
            InitializeComponent();
            BindAllProperties();
            SetLanguage();
            if (!check_openWithWindows.Enabled)
                label_NoAdmin.Visible = true;

            btn_checkForUpdates.Click += updates.Btn_checkForUpdates_Click;
        }

        private void BindAllProperties()
        {
            check_UseWhiteIcon.DataBindings.Add("Checked", Properties.Settings.Default, "UseWhiteIcon",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_NotifyOfCopy.DataBindings.Add("Checked", Properties.Settings.Default, "NotifyCopy",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_notifTimeout.DataBindings.Add("Value", Properties.Settings.Default, "NotificationTimeout",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_SaveToFile.DataBindings.Add("Checked", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_AutoClearHistory.DataBindings.Add("Checked", Properties.Settings.Default, "AutoClearClip",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_clearAfter.DataBindings.Add("Value", Properties.Settings.Default, "AutoClsTime",
                true, DataSourceUpdateMode.OnPropertyChanged);

            combo_timeFormat.DataBindings.Add("SelectedItem", Properties.Settings.Default, "AutoClsType",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_openWithWindows.DataBindings.Add("Checked", Properties.Settings.Default, "OpenWithWin",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txt_FileLocation.DataBindings.Add("Text", Properties.Settings.Default, "SaveFileLocation",
                true, DataSourceUpdateMode.OnPropertyChanged);

            radio_append.DataBindings.Add("Checked", Properties.Settings.Default, "AppendFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_writeInRealTime.DataBindings.Add("Checked", Properties.Settings.Default, "WriteInRealTime",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_notifTimeout.DataBindings.Add("Enabled", Properties.Settings.Default, "NotifyCopy",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txt_FileLocation.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            btn_browse.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            radio_append.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            radio_replace.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_writeInRealTime.DataBindings.Add("Enabled", Properties.Settings.Default, "SaveToFile",
                true, DataSourceUpdateMode.OnPropertyChanged);

            numeric_clearAfter.DataBindings.Add("Enabled", Properties.Settings.Default, "AutoClearClip",
                true, DataSourceUpdateMode.OnPropertyChanged);

            combo_timeFormat.DataBindings.Add("Enabled", Properties.Settings.Default, "AutoClearClip",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_openWithWindows.DataBindings.Add("Enabled", Properties.Settings.Default, "CanRestartAsAdmin",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_StartMinimized.DataBindings.Add("Enabled", Properties.Settings.Default, "OpenWithWin",
                true, DataSourceUpdateMode.OnPropertyChanged);

            radio_MinimizeOnClose.DataBindings.Add("Checked", Properties.Settings.Default, "MinimizeOnClose",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_HideDonate.DataBindings.Add("Checked", Properties.Settings.Default, "DisplayDonate",
                true, DataSourceUpdateMode.OnPropertyChanged);

            check_UpdateOnStartup.DataBindings.Add("Checked", Properties.Settings.Default, "AutoCheckUpdates",
                true, DataSourceUpdateMode.OnPropertyChanged);

            combo_lang.DataBindings.Add("Text", Properties.Settings.Default, "CurrentLanguage",
                true, DataSourceUpdateMode.OnPropertyChanged);

            label_version.Text = $"{resManager.GetString("Label_Version")} {updates.GetVersionNumber()}";
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
            if (check_StartMinimized.Checked)
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
            if (combo_timeFormat.SelectedItem.Equals("Seconds"))
            {
                numeric_clearAfter.Value = 30;
                numeric_clearAfter.Minimum = 30;
                combo_timeFormat.SelectedItem = "Seconds";
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
            SetLanguage();
        }

        private void SetLanguage()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.lang_{Properties.Settings.Default.CurrentLanguage}",
                Assembly.GetExecutingAssembly());
            Text = resManager.GetString("Options_Title");
            groupBox_General.Text = resManager.GetString("GroupBox_General");
            groupBox_Behaviour.Text = resManager.GetString("GroupBox_BehaviourAndVisuals");
            groupBox_SaveSettings.Text = resManager.GetString("GroupBox_SaveToFileSettings");
            groupBox_Update.Text = resManager.GetString("GroupBox_UpdateAndCurrentVersion");
            check_UseWhiteIcon.Text = resManager.GetString("Check_UseWhiteIcon");
            check_NotifyOfCopy.Text = resManager.GetString("Check_NotifyOfCopy");
            check_SaveToFile.Text = resManager.GetString("Check_SaveToFile");
            check_AutoClearHistory.Text = resManager.GetString("Check_AutoClearClipboard");
            check_openWithWindows.Text = resManager.GetString("Check_OpenWithWin");
            check_StartMinimized.Text = resManager.GetString("Check_StartMinimized");
            check_HideDonate.Text = resManager.GetString("Check_ShowDonation");
            check_writeInRealTime.Text = resManager.GetString("Check_WriteInRealTime");
            check_UpdateOnStartup.Text = resManager.GetString("Check_UpdateOnStartup");
            label_ShowNotificationFor.Text = resManager.GetString("Label_ShowNotificationFor");
            label_every.Text = resManager.GetString("Label_Every");
            label_WhenMainWinClosed.Text = resManager.GetString("Label_WhenMainWindowClosed");
            label_Lang.Text = resManager.GetString("Label_Lang");
            label_FileLocation.Text = resManager.GetString("Label_FileLocation");
            label_WriteRealTimeInfo.Text = resManager.GetString("Label_WriteRealTimeInfo");
            radio_MinimizeOnClose.Text = resManager.GetString("Radio_Minimize");
            radio_ExitOnClose.Text = resManager.GetString("Radio_ExitApp");
            radio_append.Text = resManager.GetString("Radio_Append");
            radio_replace.Text = resManager.GetString("Radio_EmptyAndReplace");
            btn_checkForUpdates.Text = resManager.GetString("Btn_CheckForUpdates");
            btn_about.Text = resManager.GetString("Btn_About");
            btn_browse.Text = resManager.GetString("Btn_Browse");
            btn_apply.Text = resManager.GetString("Btn_Apply");
            btn_close.Text = resManager.GetString("Btn_Close");
        }
    }
}
