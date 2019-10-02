using CloudConnectionLib.Messages;
using Newtonsoft.Json;
using SettingsLib;
using System;
using System.ComponentModel;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CloudConnectionLib
{
    public class ApiFunction
    {
        private OnlineSettings _onlineSettings;
        private ApiMessage _message;
        private HttpClient client;

        public ApiFunction(OnlineSettings settings)
        {
            _onlineSettings = settings;
            client = new HttpClient();

            if (_onlineSettings.ApplicationId.Equals(null))
                _onlineSettings.ApplicationId = Guid.NewGuid();
            else if (_onlineSettings.GroupId.Equals(null))
                _onlineSettings.GroupId = Guid.NewGuid();
            else if (_onlineSettings.Password.Equals(null))
                _onlineSettings.Password = Guid.NewGuid().ToString();

            _onlineSettings.PropertyChanged += SettingsChanged;
        }

        private async void SettingsChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Password"))
            {
                var Message = new NewPasswordMessage()
                {
                    ApplicationId = _onlineSettings.ApplicationId,
                    GroupId = _onlineSettings.GroupId,
                    OldPassword = _onlineSettings.OldPassword,
                    NewPassword = _onlineSettings.Password
                };
                await Call(Function.ChangePassword, string.Empty, Message);
            }
        }

        public async Task<HttpResponseMessage> Call(Function function, string content = "", NewPasswordMessage pwdChange = null)
        {
            if (function.Equals(Function.Unregister))
                InitNewMessageObject(content, true);
            else
                InitNewMessageObject(content);


            var json = JsonConvert.SerializeObject(_message);
            var pwdChangeJson = JsonConvert.SerializeObject(pwdChange);

            switch (function)
            {
                case Function.Register:
                    return await Post("http://localhost:7071/api/register", json);
                case Function.Unregister:
                    return await Post("http://localhost:7071/api/unregister", json);
                case Function.UnregisterAll:
                    return await Post("http://localhost:7071/api/unregisterall", json);
                case Function.ChangePassword:
                    return await Post("http://localhost:7071/api/changepassword", pwdChangeJson);
                case Function.SendMessage:
                    return await Post("http://localhost:7071/api/sendmessage", json);
                default:
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
        }

        private void InitNewMessageObject(string content = "", bool ForUnregistering = false)
        {
            _message = new ApiMessage
            {
                GroupId = ForUnregistering ? _onlineSettings.OldGroupId : _onlineSettings.GroupId,
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

        public enum Function
        {
            Register,
            Unregister,
            UnregisterAll,
            ChangePassword,
            SendMessage
        }
    }
}
