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

//Validation is still needed in all functions (not just this one)
//You can take a look at FluentValidation library, very nice and easy one
//If you need help with it I can help later, just ask

namespace ClipboardMonitorLite.Functions
{
    public static class ChangePassword
    {
        [FunctionName("ChangePassword")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] ChangePasswordInfo info,
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

            if(application.Password.Equals(info.Password) == false)
            {
                return new UnauthorizedResult();
            }

            var query = table.CreateQuery<ApplicationEntity>()
                            .Where(p => p.PartitionKey.Equals(info.GroupId))
                            .AsTableQuery();

            var entities = await table.ExecuteQueryAsync(query);

            var batch = new TableBatchOperation();
            foreach(var entity in entities)
            {
                entity.Password = info.NewPassword;
                batch.Replace(entity);
            }
            await table.ExecuteBatchAsync(batch);

            return new NoContentResult();
        }
    }
}
