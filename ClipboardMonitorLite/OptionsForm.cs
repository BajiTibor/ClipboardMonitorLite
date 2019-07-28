using System;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public partial class OptionsForm : Form
    {
        private Updates updates;
        public OptionsForm()
        {
            updates = new Updates();
            InitializeComponent();
            BindAllProperties();
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

            label_version.Text = $"Software Version: {updates.GetVersionNumber()}";
        }

        private void Btn_browse_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text file|*.txt";
            saveFileDialog.Title = "Save history as text file";
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
                MessageBox.Show(Constants.DonateButtonHideInfo, Constants.Title_DonateButtonHide,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.FirstTimeHiding = false;
            }
        }
    }
}
