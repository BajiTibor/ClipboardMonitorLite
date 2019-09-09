using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClipboardMonitorLite.API.Data;
using ClipboardMonitorLite.API.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos.Table;
using Newtonsoft.Json;

namespace ClipboardMonitorLite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BindController : ControllerBase
    {
        ITableUtilities _utilities;

        public BindController(ITableUtilities utilities)
        {
            _utilities = utilities;
        }

        [HttpPost]
        public async Task<IActionResult> Post(BindingInfo info)
        {
            var table = _utilities.GetCloudTable("Bindings");

            var operation = TableOperation.InsertOrReplace(new TableEntity
            {
                PartitionKey = info.SourceId,
                RowKey = info.TargetId
            });

            await table.ExecuteAsync(operation);

            operation = TableOperation.InsertOrReplace(new TableEntity
            {
                PartitionKey = info.TargetId,
                RowKey = info.SourceId
            });

            await table.ExecuteAsync(operation);

            return new NoContentResult();
        }
    }
}