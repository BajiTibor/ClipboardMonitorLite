using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite
{
    public class UpdateInformation : INotifyPropertyChanged
    {
        private string updatecheckinfo;
        public string UpdateCheckInformation {
            get
            {
                return updatecheckinfo;
            }
            set
            {
                updatecheckinfo = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("UpdateCheckInformation"));
            }
        }

        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
