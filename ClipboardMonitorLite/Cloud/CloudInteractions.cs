using Microsoft.AspNetCore.SignalR.Client;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.Resources;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.Windows;

namespace ClipboardMonitorLite.Cloud
{
    public class CloudInteractions
    {
        private HubConnection connection;
        public event EventHandler MessageRecieved;
        public CloudInteractions()
        {
            connection = new HubConnectionBuilder().WithUrl("https://localhost:5001/broadcast").Build();
            FetchText();
        }

        private async void FetchText()
        {
            await connection.StartAsync();

            await Task.Factory.StartNew(
                () => HandleMessages(),
                TaskCreationOptions.LongRunning);
        }
        
        public async void SendText(string MachineName, string Text)
        {
            await connection.SendAsync("broadcastMessage", MachineName, Text);
        }

        private void HandleMessages()
        {
            connection.On<string, string>("broadcastMessage", (user, message) =>
            {
                if (user.Equals(Constants.MachineName))
                {
                    var args = new MessageEventArgs
                    {
                        User = user,
                        Message = message
                    };
                    OnMessageRecieved(args);
                }
            });

            Thread.Sleep(-1);
        }

        protected virtual void OnMessageRecieved(EventArgs e)
        {
            EventHandler handler = MessageRecieved;
            handler?.Invoke(this, e);
        }
    }

    public class MessageEventArgs : EventArgs
    {
        public string User { get; set; }
        public string Message { get; set;  }
    }
}