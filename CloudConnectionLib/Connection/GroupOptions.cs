using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CloudConnectionLib.Connection
{
    public class GroupOptions : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string groupId;
        public string GroupId
        {
            get
            {
                return groupId;
            }
            set
            {
                groupId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(GroupId)));
            }
        }

        private Guid applicationId;
        public Guid ApplicationId
        {
            get
            {
                return applicationId;
            }
            set
            {
                applicationId = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(ApplicationId)));
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(Password)));
            }
        }

        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
