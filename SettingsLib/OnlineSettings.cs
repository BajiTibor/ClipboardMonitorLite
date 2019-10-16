using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SettingsLib
{
    public class OnlineSettings : INotifyPropertyChanged, IAppSettings
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //What's this?
        //Besides that should be an Enum rather than a string.
        public string Type
        {
            get
            {
                return "OnlineSettings";
            }
        }

        //Is this really needed? You don't do anything with the value before assigning
        //You could keep it simple with `public string OldGroupId { get; set; }`
        //Also for what oldGroupId is even used, is it needed? In my opinon such things as,
        //  old id's could be stored in dictionary or a list, if they're required.
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


        //Simmilar thing here as above, is it needed to use full property?
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
