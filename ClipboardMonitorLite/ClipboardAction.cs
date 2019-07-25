using System;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public class ClipboardAction
    {
        private VirtualClipboard vr;
        public ClipboardAction(VirtualClipboard virtClip)
        {
            vr = virtClip;
        }
        public void ClearClip_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        public void ClearHistory_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            vr.History = string.Empty;
        }

    }
}
