using System.ComponentModel;

namespace ClipboardMonitorLite
{
    public class VirtualClipboard : INotifyPropertyChanged
    {
        private string history;
        private string lastCopied;

        public string LastCopied
        {
            get { return lastCopied; }
            set
            {
                lastCopied = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("LastCopied"));
            }
        }

        public string History
        {
            get { return history; }
            set
            {
                history = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("History"));
            }
        }

        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
