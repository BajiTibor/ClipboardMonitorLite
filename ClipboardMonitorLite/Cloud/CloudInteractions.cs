using ClipboardMonitorLite.Resources;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClipboardMonitorLite.Cloud
{
    public class CloudInteractions
    {
        private HubConnection connection;
        private ClipMessage _message;
        
        public CloudInteractions(ClipMessage message)
        {
            connection = new HubConnectionBuilder().WithUrl("http://clipmanagerweb.azurewebsites.net/broadcast").Build();
            //connection = new HubConnectionBuilder().WithUrl("https://localhost:5001/broadcast").Build();
            _message = message;
            StartListening();
        }

        private async void StartListening()
        {
            connection.On<string, string>("broadcastMessage", (user, message) =>
            {
                if (!_message.MachineName.Equals(Constants.MachineName))
                {
                    _message.Message = message;
                }
            });

            await connection.StartAsync();
        }

        public async void SendText(string MachineName, string Text)
        {
            await connection.SendAsync("broadcastMessage", MachineName, Text);
        }
    }
}