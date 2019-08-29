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
        public BackgroundWorker worker;
        private ClipMessage _message;
        public CloudInteractions(ClipMessage message)
        {
            connection = new HubConnectionBuilder().WithUrl("https://localhost:5001/broadcast").Build();
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(HandleMessages);
            _message = message;
            FetchText();
        }

        private async void FetchText()
        {
            worker.RunWorkerAsync();

            await connection.StartAsync();
        }

        public async void SendText(string MachineName, string Text)
        {
            await connection.SendAsync("broadcastMessage", MachineName, Text);
        }

        private void HandleMessages(object sender, DoWorkEventArgs args)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            connection.On<string, string>("broadcastMessage", (user, message) =>
            {
                if (user.Equals(Constants.MachineName))
                {
                    _message.Message = message;
                }
            });

            Thread.Sleep(-1);
        }
    }
}