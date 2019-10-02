using System;
using System.Collections.Generic;
using System.Text;

namespace CloudConnectionLib.Messages
{
    public class NewPasswordMessage
    {
        public string GroupId { get; set; }
        public Guid ApplicationId { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }  
    }
}
