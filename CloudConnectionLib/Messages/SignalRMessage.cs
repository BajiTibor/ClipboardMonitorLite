using CloudConnectionLib.Messages.Interface;
using System.ComponentModel;

namespace CloudConnectionLib.Messages
{
    public class SignalRMessage : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string messageType;
        public string Type
        {
            get
            {
                return messageType;
            }
            set
            {
                messageType = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Type"));
            }
        }

        private string messageContent;
        public string Content
        {
            get
            {
                return messageContent;
            }
            set
            {
                messageContent = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Content"));
            }
        }

        private string machineName;
        public string MachineName
        {
            get
            {
                return machineName;
            }
            set
            {
                machineName = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MachineName"));
            }
        }

        private string guid;
        public string Guid
        {
            get
            {
                return guid;
            }
            set
            {
                guid = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("GUID"));
            }
        }


        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
