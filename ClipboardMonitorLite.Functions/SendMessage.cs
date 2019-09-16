using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;
using ClipboardMonitorLite.Functions.Data;
using ClipboardMonitorLite.Functions.Utilities;
using Microsoft.Azure.Cosmos.Table;

namespace ClipboardMonitorLite.Functions
{
    public static class SendMessage
    {
        [FunctionName("SendMessage")]
        public static Task Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]Message message,
            [SignalR(HubName = "Messages")]IAsyncCollector<SignalRMessage> signalRMessages)
        {
            var table = TableUtilities.GetCloudTable("Applications");

            var operation = TableOperation.Retrieve<ApplicationEntity>(message.GroupId, message.ApplicationId);
            var result = table.Execute(operation);
            var application = result.Result as ApplicationEntity;

            if (application == null)
            {
                return Task.CompletedTask;
            }

            if(application.Password.Equals(message.Password) == false)
            {
                return Task.CompletedTask;
            }

            return signalRMessages.AddAsync(
                new SignalRMessage
                {
                    Target = message.GroupId,
                    Arguments = new[] { message.Content }
                });
        }
    }
}
