using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.SignalR.Data
{
    public class Message
    {
        public string SourceId { get; set; }
        public string TargetId { get; set; }
        public string Content { get; set; }
    }
}
