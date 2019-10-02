using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SettingsLib
{
    public class OnlineSettings : INotifyPropertyChanged, IAppSettings
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Type
        {
            get
            {
                return "OnlineSettings";
            }
        }

        private string oldGroupId;
        public string OldGroupId
        {
            get
            {
                return oldGroupId;
            }
            set
            {
                oldGroupId = value;
            }
        }

        private string groupId;
        public string GroupId
        {
            get 
            { 
                return groupId;
            }
            set 
            {
                OldGroupId = groupId;
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

        private string oldPassword;
        public string OldPassword
        {
            get
            {
                return oldPassword;
            }
            set
            {
                oldPassword = value;
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
                OldPassword = password;
                password = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(Password)));
            }
        }

        private void InvokePropertyChanged(PropertyChangedEventArgs arg)
        {
            PropertyChanged?.Invoke(this, arg);
        }
    }
}
