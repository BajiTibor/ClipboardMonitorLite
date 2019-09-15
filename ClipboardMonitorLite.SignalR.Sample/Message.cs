using System;
using System.Collections.Generic;
using System.Text;

namespace ClipboardMonitorLite.SignalR.Sample
{
    public class Message
    {
        public string GroupId { get; set; }
        public string ApplicationId { get; set; }
        public string Password { get; set; }
        public string Content { get; set; }
    }
}
