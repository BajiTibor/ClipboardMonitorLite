using System;
using System.Collections.Generic;
using System.Text;

namespace CloudConnectionLib.Messages.Interface
{
    public interface ICloudMessage
    {
        string Type { get; set; }
        string Content { get; set; }
        string MachineName { get; set; }
        string Guid { get; set; }
    }
}
