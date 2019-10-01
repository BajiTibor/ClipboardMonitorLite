using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SettingsLib
{
    public class OnlineInformation : INotifyPropertyChanged, IAppSettings
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Type
        {
            get
            {
                return "OnlineSettings";
            }
        }

        private Guid groupId;
        public Guid GroupId
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

        private void InvokePropertyChanged(PropertyChangedEventArgs arg)
        {
            PropertyChanged?.Invoke(this, arg);
        }

    }
}
