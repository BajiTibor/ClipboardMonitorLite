using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public class ChangeControl
    {
        public void ChangeText(NotifyIcon SourceControl)
        {
            SourceControl.BalloonTipText = "TEST";
            SourceControl.BalloonTipTitle = "TEST2";
            SourceControl.ShowBalloonTip(4);
        }
    }
}
