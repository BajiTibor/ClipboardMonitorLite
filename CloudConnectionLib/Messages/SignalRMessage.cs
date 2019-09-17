using System.ComponentModel;

namespace CloudConnectionLib.Messages
{
    /// <summary>
    /// Message object that gets sent or received by SignalR.
    /// </summary>
    public class SignalRMessage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(Content)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(MachineName)));
            }
        }

        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
