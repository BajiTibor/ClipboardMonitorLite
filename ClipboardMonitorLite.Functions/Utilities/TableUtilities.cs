using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClipboardMonitorLite.Functions.Utilities
{
    public class TableUtilities
    {
        public static CloudTable GetCloudTable(string name)
        {
            var account = CloudStorageAccount.Parse(Environment.GetEnvironmentVariable("StorageConnectionString"));
            var client = account.CreateCloudTableClient();
            var table = client.GetTableReference(name);
            table.CreateIfNotExistsAsync();
            return table;
        }
    }
}
