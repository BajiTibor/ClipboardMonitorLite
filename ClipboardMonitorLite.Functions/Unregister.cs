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
using ClipboardMonitorLite.Functions.Extensions;
using Microsoft.Azure.Cosmos.Table.Queryable;

namespace ClipboardMonitorLite.Functions
{
    public static class Unregister
    {
        [FunctionName("Unregister")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] ApplicationInfo info,
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

            operation = TableOperation.Delete(application);
            await table.ExecuteAsync(operation);

            return new NoContentResult();
        }
    }
}
