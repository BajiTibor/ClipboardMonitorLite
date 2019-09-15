using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClipboardMonitorLite.Functions.Data
{
    public class ApplicationEntity : TableEntity
    {
        public string MachineName { get; set; }
        public string Password { get; set; }
    }
}
