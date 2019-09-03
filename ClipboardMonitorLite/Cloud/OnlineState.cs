using Microsoft.AspNetCore.SignalR.Client;

namespace ClipboardMonitorLite.Cloud
{
    public static class OnlineState
    {
        public static HubConnectionState ConnectionLife = HubConnectionState.Disconnected;
    }
}
