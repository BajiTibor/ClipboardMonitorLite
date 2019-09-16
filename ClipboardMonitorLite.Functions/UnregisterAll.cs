using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ClipboardMonitorLite.Functions.Data;
using Microsoft.Azure.Cosmos.Table;
using ClipboardMonitorLite.Functions.Utilities;
using Microsoft.Azure.Cosmos.Table.Queryable;
using ClipboardMonitorLite.Functions.Extensions;

namespace ClipboardMonitorLite.Functions
{
    public static class UnregisterAll
    {
        [FunctionName("UnregisterAll")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post")] ApplicationInfo info,
            ILogger log)
        {
            var table = TableUtilities.GetCloudTable("Applications");

            var operation = TableOperation.Retrieve<ApplicationEntity>(info.GroupId, info.ApplicationId);
            var result = await table.ExecuteAsync(operation);
            var application = result.Result as ApplicationEntity;

            if (application == null)
            {
                return new NotFoundResult();
            }

            if (application.Password.Equals(info.Password) == false)
            {
                return new UnauthorizedResult();
            }

            var query = table.CreateQuery<ApplicationEntity>()
                            .Where(p => p.PartitionKey.Equals(info.GroupId))
                            .AsTableQuery();

            var entities = await table.ExecuteQueryAsync(query);

            var batch = new TableBatchOperation();
            foreach (var entity in entities)
            {
                batch.Delete(entity);
            }
            await table.ExecuteBatchAsync(batch);

            return new NoContentResult();
        }
    }
}
