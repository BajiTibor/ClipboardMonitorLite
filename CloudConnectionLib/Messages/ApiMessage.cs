using System;
using System.Collections.Generic;
using System.Text;

namespace CloudConnectionLib.Messages
{
    public class ApiMessage
    {
        public Guid GroupId { get; set; }
        public Guid ApplicationId { get; set; }
        public string MachineName { get; set; }
        public string Password { get; set; }
        public string Content { get; set; }
    }
}
