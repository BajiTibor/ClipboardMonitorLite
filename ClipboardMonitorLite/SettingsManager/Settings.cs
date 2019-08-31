using System.ComponentModel;

namespace ClipboardMonitorLite.SettingsManager
{
    public class Settings : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        bool usingWhiteIcon;
        public bool UsingWhiteTrayIcon
        {
            get
            {
                return usingWhiteIcon;
            }
            set
            {
                usingWhiteIcon = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("UsingWhiteTrayIcon"));
            }
        }

        bool notifyClipChange;
        public bool NotifyClipboardChange
        {
            get
            {
                return notifyClipChange;
            }
            set
            {
                notifyClipChange = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("NotifyClipboardChange"));
            }
        }

        bool saveClipHistory;
        public bool SaveClipboardHistory
        {
            get
            {
                return saveClipHistory;
            }
            set
            {
                saveClipHistory = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("SaveClipboardHistory"));
            }
        }

        bool autoClearHistory;
        public bool AutoClearClipboardHistory
        {
            get
            {
                return autoClearHistory;
            }
            set
            {
                autoClearHistory = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("AutoClearClipboardHistory"));
            }
        }

        bool minimizeOnClose;
        public bool MinimizeOnClose
        {
            get
            {
                return minimizeOnClose;
            }
            set
            {
                minimizeOnClose = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MinimizeOnClose"));
            }
        }

        bool showDonationButton;
        public bool ShowDonation
        {
            get
            {
                return showDonationButton;
            }
            set
            {
                showDonationButton = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ShowDonation"));
            }
        }

        int selectedLanguage;
        public int CurrentlySelectedLanguage
        {
            get
            {
                return selectedLanguage;
            }
            set
            {
                selectedLanguage = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CurrentlySelectedLanguage"));
            }
        }

        string fileLocation;
        public string HistoryFileLocation
        {
            get
            {
                return fileLocation;
            }
            set
            {
                fileLocation = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("HistoryFileLocation"));
            }
        }

        bool writeRealTime;
        public bool WriteInRealTime
        {
            get
            {
                return writeRealTime;
            }
            set
            {
                writeRealTime = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("WriteInRealTime"));
            }
        }

        int clearBetweenMinutes;
        public int ClearBetween
        {
            get
            {
                return clearBetweenMinutes;
            }
            set
            {
                clearBetweenMinutes = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ClearBetween"));
            }
        }

        bool startMinimized;
        public bool StartMinimized
        {
            get
            {
                return startMinimized;
            }
            set
            {
                startMinimized = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("StartMinimized"));
            }
        }

        bool startWithWin;
        public bool StartWithWindows
        {
            get
            {
                return startWithWin;
            }
            set
            {
                startWithWin = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("StartWithWindows"));
            }
        }

        private bool onlineMode;

        public bool OnlineMode
        {
            get
            {
                return onlineMode;
            }
            set
            {
                onlineMode = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("OnlineMode"));
            }
        }

        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
