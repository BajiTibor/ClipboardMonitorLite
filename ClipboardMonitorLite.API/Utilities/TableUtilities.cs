using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.API.Utilities
{
    public class TableUtilities : ITableUtilities
    {
        IConfiguration _configuration;

        public TableUtilities(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CloudTable GetCloudTable(string name)
        {
            var account = CloudStorageAccount.Parse(_configuration["StorageConnectionString"]);
            var client = account.CreateCloudTableClient();
            var table = client.GetTableReference(name);
            table.CreateIfNotExistsAsync();
            return table;
        }
    }
}
