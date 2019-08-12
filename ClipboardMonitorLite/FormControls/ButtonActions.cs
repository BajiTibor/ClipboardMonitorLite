using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipboardMonitorLite.ClipboardActions;

namespace ClipboardMonitorLite.FormControls
{
    public class ButtonActions
    {
        private Form CurrentForm;
        private ClipboardManager ClipActions;
        private NotifyIcon NotificationIcon;
        public ButtonActions(ClipboardManager clipManager, NotifyIcon icon)
        {
            ClipActions = clipManager;
            NotificationIcon = icon;
        }
        public void ClearClipboardClick(object sender, EventArgs e)
        {
            ClipActions.ClearClip();
        }

        public void ClearHistoryClick(object sender, EventArgs e)
        {
            ClipActions.ClearHistory();
        }

        public void RestoreWindowClick(object sender, EventArgs e)
        {
            ShowWindow(GetLastFormInteractedWith());
        }

        public void HideWindowClick(object sender, EventArgs e)
        {
            HideWindow(GetLastFormInteractedWith());
        }

        public void DonationClick(object sender, EventArgs e)
        {
            Process.Start(Resources.MainResources.url_KoFi);
        }

        public void ShowOptionsWindowClick(object sender, EventArgs e)
        {

        }

        public void ExitApplicationClick(object sender, EventArgs e)
        {
            NotificationIcon.Visible = false;
            NotificationIcon.Dispose();
            Application.Exit();
        }

        private void HideWindow(Form form)
        {
            form.ShowInTaskbar = false;
        }

        private void ShowWindow(Form form)
        {
            form.WindowState = FormWindowState.Normal;
            form.ShowInTaskbar = true;
        }

        private Form GetLastFormInteractedWith()
        {
            if (CurrentForm == null)
            {
                CurrentForm = Application.OpenForms.Cast<Form>().FirstOrDefault();
            }
            else
            {
                return CurrentForm;
            }
            return CurrentForm;
        }
    }
}
