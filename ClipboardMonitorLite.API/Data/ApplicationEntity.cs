using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClipboardMonitorLite.API.Data
{
    public class ApplicationEntity : TableEntity
    {
        public string ConnectionId { get; set; }
        public string MachineName { get; set; }
    }
}
