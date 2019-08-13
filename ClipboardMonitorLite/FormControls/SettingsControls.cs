using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ClipboardMonitorLite.SettingsManager;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.FormControls
{
    public class SettingsControls
    {
        private Settings _settings;
        public SettingsControls(Settings settings)
        {
            _settings = settings;
        }
        public void MinimizeCheckChange(object sender, EventArgs e)
        {
            if (_settings.StartMinimized)
            {
                _settings.StartupWindowState = FormWindowState.Minimized;
            }
            else
            {
                _settings.StartupWindowState = FormWindowState.Normal;
            }
        }
    }
}
