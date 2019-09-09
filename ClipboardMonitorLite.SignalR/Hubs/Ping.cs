using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.SignalR.Hubs
{
    public class Ping : Hub
    {
        public void SendConnectionId()
        {
            Clients.Caller.SendAsync("ping", Context.ConnectionId);
        }
    }
}
