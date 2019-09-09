using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClipboardMonitorLite.API.Data;
using ClipboardMonitorLite.API.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ClipboardMonitorLite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        ITableUtilities _utilities;

        public RegisterController(ITableUtilities utilities)
        {
            _utilities = utilities;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ApplicationInfo info)
        {
            var table = _utilities.GetCloudTable("Applications");

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