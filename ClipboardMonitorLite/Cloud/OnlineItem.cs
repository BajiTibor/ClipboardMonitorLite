using ClipboardMonitorLite.ClipboardActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.Cloud
{
    public class OnlineItem
    {
        private ClipboardManager _ClipManager;

        public OnlineItem(ClipboardManager manager)
        {
            _ClipManager = manager;
        }

        public void NewMessage()
        {
            _ClipManager.MessageFromCloud();
        }

    }
}
