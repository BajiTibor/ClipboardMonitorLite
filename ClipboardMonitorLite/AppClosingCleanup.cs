using ClipboardLibrary;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public class AppClosingCleanup
    {
        public void CloseApplication(FileOperation file, VirtualClipboard clipboard,
            NotifyIcon icon)
        {
            if (!UserSettings.CustomSettings.Default.RealTimeWrite)
            {
                try
                {
                    file.WriteBeforeClosing(clipboard);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            UserSettings.CustomSettings.Default.Save();

            icon.Visible = false;
            icon.Dispose();

            foreach (var item in Application.OpenForms.Cast<Form>())
            {
                item.Close();
                item.Dispose();
            }
            Application.Exit();
        }
    }
}
