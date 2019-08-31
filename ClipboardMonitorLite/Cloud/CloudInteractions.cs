using ClipboardMonitorLite.Resources;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.Cloud
{
    public class CloudInteractions
    {
        private ClipMessage _message;
        private HubConnection connection;

        public CloudInteractions(ClipMessage message)
        {
            connection = new HubConnectionBuilder().WithUrl("http://clipmanagerweb.azurewebsites.net/broadcast").Build();

            _message = message;

            StartListening();

            connection.Closed += Connection_Closed;
        }

        private async void StartListening()
        {
            try
            {
                await connection.StartAsync();
                connection.On<string, string>("broadcastMessage", (user, message) =>
                {
                    _message.Message = message;
                });
            }
            catch
            {
                await RetryConnection(0);
            }
        }

        public async void SendText(string MachineName, string Text)
        {
            await connection.SendAsync("broadcastMessage", MachineName, Text);
        }

        private async Task Connection_Closed(Exception arg)
        {
            await RetryConnection(0);
        }
        
        private async Task RetryConnection(int retries)
        {
            int delay = 15000;
            if (retries > 2)
            { delay *= 2; }
            retries++;
            try
            {
                await Task.Delay(delay);
                await connection.StartAsync();
            }
            catch
            {
                await RetryConnection(retries);
            }
        }
    }
}