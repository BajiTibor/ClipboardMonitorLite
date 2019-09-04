using System;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using SettingsLib;
using CloudConnectionLib.Messages;

namespace CloudConnectionLib
{
    public class CloudInteractions
    {
        private Settings _settings;
        private HubConnection connection;
        private SignalRMessage _inboundMessage;
        private SignalRMessage _outgoingMessage;

        public CloudInteractions(SignalRMessage inboundMessage, SignalRMessage outgoingMessage, Settings settings)
        {
            connection = new HubConnectionBuilder().WithUrl("http://clipmanagerweb.azurewebsites.net/broadcast").Build();
            _settings = settings;
            _inboundMessage = inboundMessage;
            _outgoingMessage = outgoingMessage;

            OnlineState.ConnectionLife = connection.State.ToString();
            if (_settings.OnlineMode)
            {
                StartListening();
            }
            _settings.PropertyChanged += OnlineModeChanged;
            _outgoingMessage.PropertyChanged += NewMessageToSend;
        }

        private async void NewMessageToSend(object sender, PropertyChangedEventArgs e)
        {
            if ((_settings.LimitTraffic && _settings.SendOnly) || (!_settings.LimitTraffic))
            {
                if (e.PropertyName.Equals("MachineName"))
                {
                    await connection.SendAsync("broadcastMessage", string.Empty, JsonConvert.SerializeObject(_outgoingMessage));
                }
            }
        }

        private void MessageArrived(SignalRMessage message)
        {
            if ((_settings.LimitTraffic && !_settings.SendOnly) || (!_settings.LimitTraffic))
            {
                _inboundMessage.Message = message.Message;
                _inboundMessage.MachineName = message.MachineName;
            }
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
                    var newMessage = JsonConvert.DeserializeObject<SignalRMessage>(message);
                    if (!newMessage.MachineName.Equals(Environment.MachineName))
                    {
                        MessageArrived(newMessage);
                    }
                });
                connection.Closed += Connection_Closed;
                OnlineState.ConnectionLife = connection.State.ToString();
            }
            catch
            {
                await RetryConnection(0);
            }
        }

        private async Task Connection_Closed(Exception arg)
        {
            OnlineState.ConnectionLife = connection.State.ToString();
            if (_settings.OnlineMode)
            {
                await RetryConnection(0);
                OnlineState.ConnectionLife = connection.State.ToString();
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