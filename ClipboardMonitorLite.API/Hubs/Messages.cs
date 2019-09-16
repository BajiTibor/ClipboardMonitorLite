using ClipboardMonitorLite.API.Data;
using ClipboardMonitorLite.API.Extensions;
using ClipboardMonitorLite.API.Utilities;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Azure.Cosmos.Table.Queryable;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.API.Hubs
{
    public class Messages : Hub
    {
        ITableUtilities _utilities;

        public Messages(ITableUtilities utilities)
        {
            _utilities = utilities;
        }

        public async Task UpdateConnectionInfo(string Id)
        {
            var table = _utilities.GetCloudTable("Applications");

            var operation = TableOperation.Retrieve<ApplicationEntity>(Id, Id);
            var result = await table.ExecuteAsync(operation);

            var info = result.Result as ApplicationEntity;

            info.ConnectionId = Context.ConnectionId;

            operation = TableOperation.Replace(info);
            await table.ExecuteAsync(operation);
        }

        public async Task SendRequest(string sourceId, string targetId)
        {
            var table = _utilities.GetCloudTable("Applications");

            var operation = TableOperation.Retrieve<ApplicationEntity>(targetId, targetId);
            var result = await table.ExecuteAsync(operation);

            var info = result.Result as ApplicationEntity;

            await Clients.Client(info.ConnectionId).SendAsync("Prompt", sourceId, targetId);
        }

        public async Task SendMessage(string id, string content)
        {
            var table = _utilities.GetCloudTable("Bindings");
            var query = table.CreateQuery<TableEntity>()
                            .Where(p => p.PartitionKey.Equals(id))
                            .AsTableQuery();

            var entities = await table.ExecuteQueryAsync(query);

            var connections = new List<string>();
            table = _utilities.GetCloudTable("Applications");

            foreach(var entity in entities)
            {
                var operation = TableOperation.Retrieve<ApplicationEntity>(entity.RowKey, entity.RowKey);
                var result = await table.ExecuteAsync(operation);

                var info = result.Result as ApplicationEntity;
                connections.Add(info.ConnectionId);
            }

            foreach(var connection in connections)
            {
                await Clients.Client(connection).SendAsync("Broadcast", content);
            }
        }
    }
}
