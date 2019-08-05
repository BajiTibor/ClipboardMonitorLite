using ClipboardLibrary;
using System;
using System.Resources;
using System.Linq;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public class FormActions
    {
        private NotifyIcon icon;
        private VirtualClipboard virtualClipboard;
        private ResourceManager ResManager;
        private FileOperation File;
        private AppClosingCleanup cleanup;

        public FormActions(NotifyIcon Icon, VirtualClipboard clipboard, ResourceManager resManager,
            FileOperation file)
        {
            icon = Icon;
            virtualClipboard = clipboard;
            ResManager = resManager;
            File = file;
        }

        private Form FetchForm()
        {
            return Application.OpenForms.Cast<Form>().Last();
        }

        public void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void ResizeFormObject(object sender, EventArgs e)
        {
            Resize(FetchForm());
        }

        public void RestoreFormObject(object sender, EventArgs e)
        {
            Restore(FetchForm());
        }

        private void ClosingOrMinimize(FormClosingEventArgs e)
        {
            if (UserSettings.CustomSettings.Default.MinimizeOnClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                FetchForm().WindowState = FormWindowState.Minimized;
            }
            else
            {
                UserSettings.CustomSettings.Default.Save();
                if (!UserSettings.CustomSettings.Default.RealTimeWrite)
                {
                    File.WriteBeforeClosing(virtualClipboard);
                }
                Application.Exit();
            }
        }
        

        public void FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingOrMinimize(e);
        }

        private void Restore(Form form)
        {
            form.Show();
            form.WindowState = FormWindowState.Normal;
            form.Focus();
        }

        private void Resize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.Hide();
            }
            else form.Show();
        }

        public void SetTaskbarIcon()
        {
            if (UserSettings.CustomSettings.Default.UseWhiteIcon)
                icon.Icon = Constants.whiteIcon;
            else
                icon.Icon = Constants.darkIcon;
        }

        public void FirstTimeUseMinimize()
        {
            if (UserSettings.CustomSettings.Default.FirstTimeUse)
            {
                icon.BalloonTipText = ResManager.GetString("Notif_AppStillRunning");
                icon.BalloonTipTitle = ResManager.GetString("Notif_Title_AppStillRunning");
                icon.ShowBalloonTip(4);
                UserSettings.CustomSettings.Default.FirstTimeUse = false;
            }
        }
    }
}
