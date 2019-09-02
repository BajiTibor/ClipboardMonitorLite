﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using ClipboardMonitorLite.SettingsManager;

namespace ClipboardMonitorLite.Cloud
{
    public class CloudInteractions
    {
        private Settings _settings;
        private ClipMessage _message;
        private HubConnection connection;
        private OnlineItem _newItem;

        public CloudInteractions(ClipMessage message, Settings settings)
        {
            connection = new HubConnectionBuilder().WithUrl("http://clipmanagerweb.azurewebsites.net/broadcast").Build();
            _settings = settings;
            _message = message;

            onState.ConnectionLife = connection.State;
            if (_settings.OnlineMode)
            {
               StartListening();
            }
            _settings.PropertyChanged += OnlineModeChanged;
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
                        _message.Message = message;
                        _message.MachineName = user;
                    
                });
                connection.Closed += Connection_Closed;
                onState.ConnectionLife = connection.State;
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