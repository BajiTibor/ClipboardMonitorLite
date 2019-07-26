using System;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public class ClipboardAction
    {
        private VirtualClipboard _virtualClipboard;
        public ClipboardAction(VirtualClipboard virtualClipboard)
        {
            _virtualClipboard = virtualClipboard;
        }

        public void ClearClip_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        public void ClearHistory_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            _virtualClipboard.History = string.Empty;
        }

    }
}
