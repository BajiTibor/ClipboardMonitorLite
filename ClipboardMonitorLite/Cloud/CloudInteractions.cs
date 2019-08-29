using Microsoft.AspNetCore.SignalR.Client;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.Resources;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.Windows;
using System.ComponentModel;

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
            FetchText();
        }

        private async void FetchText()
        {
            await Task.Factory.StartNew(() => HandleMessages(), TaskCreationOptions.LongRunning);

            await connection.StartAsync();
        }

        public async void SendText(string MachineName, string Text)
        {
            await connection.SendAsync("broadcastMessage", MachineName, Text);
        }

        private async Task HandleMessages()
        {
            connection.On<string, string>("broadcastMessage", (user, message) =>
            {
                //if (!user.Equals(Constants.MachineName))
                //{
                _message.Message = message;
                //}

                
            });

            await Task.Delay(-1);
        }
    }
}