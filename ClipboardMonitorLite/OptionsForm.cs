using System;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            BindAllProperties();
            if (!check_openWithWindows.Enabled)
                label_NoAdmin.Visible = true;
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

    }
}
