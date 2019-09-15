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
using ClipboardMonitorLite.Functions.Utilities;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Azure.Cosmos.Table.Queryable;
using ClipboardMonitorLite.Functions.Extensions;

namespace ClipboardMonitorLite.Functions
{
    public static class Register
    {
        [FunctionName("Register")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post")] ApplicationInfo info,
            ILogger log)
        {          
            var table = TableUtilities.GetCloudTable("Applications");

            var operation = TableOperation.Retrieve<ApplicationEntity>(info.GroupId, info.ApplicationId);
            var result = await table.ExecuteAsync(operation);
            var application = result.Result as ApplicationEntity;

            if(application != null)
            {
                return new ConflictResult();
            }

            var query = table.CreateQuery<ApplicationEntity>()
                            .Where(p => p.PartitionKey.Equals(info.GroupId))
                            .AsTableQuery();

            var entities = await table.ExecuteQueryAsync(query);

            if(entities.Count > 0 && entities.First().Password.Equals(info.Password) == false)
            {
                return new UnauthorizedResult();
            }


            operation = TableOperation.Insert(new ApplicationEntity
            {
                PartitionKey = info.GroupId,
                RowKey = info.ApplicationId,
                MachineName = info.MachineName,
                Password = info.Password
            });
            await table.ExecuteAsync(operation);

            return new NoContentResult();
        }
    }
}
