using System;
using System.Collections.Generic;
using System.Text;

namespace CloudConnectionLib.Messages
{
    public class NewPasswordMessage
    {
        public Guid GroupId { get; set; }
        public Guid ApplicationId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }  
    }
}
