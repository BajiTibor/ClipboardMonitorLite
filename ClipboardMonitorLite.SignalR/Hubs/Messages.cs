using ClipboardMonitorLite.SignalR.Data;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.SignalR.Hubs
{
    public class Messages : Hub
    {
        public void Send(string json)
        {
            //var message = JsonConvert.DeserializeObject<Message>(json);

            
        }
    }
}
