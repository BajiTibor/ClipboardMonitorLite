using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.API.Utilities
{
    public interface ITableUtilities
    {
        CloudTable GetCloudTable(string name);
    }
}
