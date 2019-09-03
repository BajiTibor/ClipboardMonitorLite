using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using ClipboardMonitorLite.SettingsManager;
using Newtonsoft.Json;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.Resources;

namespace ClipboardMonitorLite.Cloud
{
    public class CloudInteractions
    {
        private Settings _settings;
        private InboundMessage _inboundMessage;
        private HubConnection connection;
        private ClipboardManager _clipboardManager;
        private OutgoingMessage _outgoingMessage;
        private Random rng;

        public CloudInteractions(InboundMessage inboundMessage, OutgoingMessage outgoingMessage, Settings settings, ClipboardManager clipManager)
        {
            connection = new HubConnectionBuilder().WithUrl("http://clipmanagerweb.azurewebsites.net/broadcast").Build();
            _settings = settings;
            _inboundMessage = inboundMessage;
            _outgoingMessage = outgoingMessage;
            _clipboardManager = clipManager;
            rng = new Random();

            onState.ConnectionLife = connection.State;
            if (_settings.OnlineMode)
            {
               StartListening();
            }
            _settings.PropertyChanged += OnlineModeChanged;
            _outgoingMessage.PropertyChanged += NewMessageToSend;
        }

        private async void NewMessageToSend(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("MachineName"))
            {
                await connection.SendAsync("broadcastMessage", rng.Next(), JsonConvert.SerializeObject(_outgoingMessage));
            }
        }

        private void MessageArrived(InboundMessage message, int idNum)
        {
            _clipboardManager.MessageFromCloud(message, idNum);   
        }

        private void OnlineModeChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("OnlineMode"))
            {
                if (_settings.OnlineMode)
                    StartListening();
                else
                    StopConnection();
            }
        }

        private async void StopConnection()
        {
            await connection.StopAsync();
        }

        private async void StartListening()
        {
            try
            {
                await connection.StartAsync();
                connection.On<string, string>("broadcastMessage", (user, message) =>
                {
                    _inboundMessage = JsonConvert.DeserializeObject<InboundMessage>(message);
                    if (!_inboundMessage.MachineName.Equals(Constants.MachineName))
                    {
                        MessageArrived(_inboundMessage, int.Parse(user));
                    }
                });
                connection.Closed += Connection_Closed;
                onState.ConnectionLife = connection.State;
            }
            catch
            {
                await RetryConnection(0);
            }
        }

        private async Task Connection_Closed(Exception arg)
        {
            onState.ConnectionLife = connection.State;
            if (_settings.OnlineMode)
            {
                await RetryConnection(0);
                onState.ConnectionLife = connection.State;
            }
        }
        
        private async Task RetryConnection(int retries)
        {
            int delay = _settings.RetryConnectionAfter;
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