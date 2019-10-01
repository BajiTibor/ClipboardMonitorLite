using CloudConnectionLib.Messages;
using Newtonsoft.Json;
using SettingsLib;
using System;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CloudConnectionLib
{
    public class CallApiFunction
    {
        private OnlineSettings _onlineSettings;
        private ApiMessage _message;
        private HttpClient client;

        public CallApiFunction(OnlineSettings settings)
        {
            _onlineSettings = settings;
            client = new HttpClient();
        }
         // TODO: Maybe do this with a switch and enum
        public async void Unregister()
        {
            InitNewMessageObject();

            var json = JsonConvert.SerializeObject(_message);

            var answer = await Post("http://localhost:7071/api/Unregister", json);

            if (!(answer.IsSuccessStatusCode || answer.StatusCode.Equals(HttpStatusCode.Conflict)))
            {
                // Handle some error here
            }
        }

        public async void Register()
        {
            InitNewMessageObject();

            var json = JsonConvert.SerializeObject(_message);

            var answer = await Post("http://localhost:7071/api/Register", json);

            if (!(answer.IsSuccessStatusCode || answer.StatusCode.Equals(HttpStatusCode.Conflict)))
            {
                // Handle some error here
            }
        }

        private void InitNewMessageObject(string content = "")
        {
            _message = new ApiMessage
            {
                GroupId = _onlineSettings.GroupId,
                ApplicationId = _onlineSettings.ApplicationId,
                MachineName = Constants.MachineName,
                Password = _onlineSettings.Password,
                Content = content
            };
        }

        private async Task<HttpResponseMessage> Post(string url, string content)
        {
            return await client.PostAsync(url, new StringContent(content));
        }
    }
}
