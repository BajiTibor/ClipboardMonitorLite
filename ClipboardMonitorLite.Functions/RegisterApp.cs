using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ClipboardMonitorLite.Functions.Data;
using Microsoft.WindowsAzure.Storage.Table;

namespace ClipboardMonitorLite.Functions
{
    public static class RegisterApp
    {
        [FunctionName("Register")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] ApplicationInfo info,
            [Table("Applications")] CloudTable table,
            ILogger log)
        {
            log.LogInformation($"Registering application, Id: {info.Id}");

            await table.CreateIfNotExistsAsync();

            var operation = TableOperation.InsertOrReplace(new ApplicationEntity
            {
                PartitionKey = info.Id,
                RowKey = info.Id,
                ConnectionId = info.ConnectionId,
                MachineName = info.MachineName
            });

            await table.ExecuteAsync(operation);
            
            return new NoContentResult();
        }
    }
}
