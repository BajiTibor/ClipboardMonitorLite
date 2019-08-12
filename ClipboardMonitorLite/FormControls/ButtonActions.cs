using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardMonitorLite.FormControls
{
    public class ButtonActions
    {
        private Form CurrentForm;

        public void ClearClipboardClick(object sender, EventArgs e)
        {
            
        }

        public void ClearHistoryClick(object sender, EventArgs e)
        {

        }

        public void RestoreWindowClick(object sender, EventArgs e)
        {
            ShowWindow(GetLastFormInteractedWith());
        }

        public void HideWindowClick(object sender, EventArgs e)
        {
            HideWindow(GetLastFormInteractedWith());
        }

        public void ShowOptionsWindowClick(object sender, EventArgs e)
        {

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
