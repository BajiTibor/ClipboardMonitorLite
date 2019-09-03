using System.ComponentModel;

namespace CloudConnectionLib.Messages
{
    public class OutgoingMessage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Messsage"));
            }
        }

        private string machine;
        public string MachineName
        {
            get
            {
                return machine;
            }
            set
            {
                machine = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MachineName"));
            }
        }



        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
