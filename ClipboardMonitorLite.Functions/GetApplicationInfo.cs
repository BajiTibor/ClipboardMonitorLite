using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.Storage.Table;
using ClipboardMonitorLite.API.Data;
using System.Collections.Generic;
using System.Threading;

namespace ClipboardMonitorLite.Functions
{
    public static class GetApplicationInfo
    {
        [FunctionName("GetApplicationInfo")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] string Id,
            [Table("Applications")] CloudTable table,
            ILogger log)
        {
            log.LogInformation($"New request for Id: {Id}");
            

            //We prepare operation for table to get our entity you know that thing here
            var operation = TableOperation.Retrieve<ApplicationEntity>(Id, Id);
            //We execute it and await result
            var result = await table.ExecuteAsync(operation);

            //Since result is a TableResult we need to actually get out the data we want so
            //we cast it to ApplicationEntity which derives from TableEntity
            //So what we get is compatible with the result, therefore we can cast it
            var entity = result.Result as ApplicationEntity;

            //We create new object which has info we need cuz entity has a lot more than that
            var info = new ApplicationInfo
            {
                Id = entity.RowKey,
                ConnectionId = entity.ConnectionId,
                MachineName = entity.MachineName
            };

            //Jsonify
            var json = JsonConvert.SerializeObject(info);

            //And return to whoever requested that
            return new OkObjectResult(json);
        }

        public static async Task<IList<T>> ExecuteQueryAsync<T>(this CloudTable table, 
            TableQuery<T> query, CancellationToken ct = default(CancellationToken), 
            Action<IList<T>> onProgress = null) where T : ITableEntity, new()
        {

            var items = new List<T>();
            TableContinuationToken token = null;

            do
            {

                TableQuerySegment<T> seg = await table.ExecuteQuerySegmentedAsync<T>(query, token);
                token = seg.ContinuationToken;
                items.AddRange(seg);
                if (onProgress != null) onProgress(items);

            } while (token != null && !ct.IsCancellationRequested);

            return items;
        }
    }
}
