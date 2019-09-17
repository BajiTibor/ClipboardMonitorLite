using System.ComponentModel;

namespace SettingsLib
{
    /// <summary>
    /// Settings object that's used to store the user's preferences.
    /// </summary>
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(UsingWhiteTrayIcon)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(NotifyClipboardChange)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(SaveClipboardHistory)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(AutoClearClipboardHistory)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(MinimizeOnClose)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(ShowDonation)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(CurrentlySelectedLanguage)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(HistoryFileLocation)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(WriteInRealTime)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(ClearBetween)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(StartMinimized)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(StartWithWindows)));
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
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(OnlineMode)));
            }
        }

        private bool useTimestamp;
        public bool UseTimestamp
        {
            get
            {
                return useTimestamp;
            }
            set
            {
                useTimestamp = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(UseTimestamp)));
            }
        }

        private bool limitTraffic;
        public bool LimitTraffic
        {
            get
            {
                return limitTraffic;
            }
            set
            {
                limitTraffic = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(LimitTraffic)));
            }
        }

        private bool sendOnly;
        public bool SendOnly
        {
            get
            {
                return sendOnly;
            }
            set
            {
                sendOnly = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(SendOnly)));
            }
        }

        private int retryConnectionAfter;
        public int RetryConnectionAfter
        {
            get
            {
                return retryConnectionAfter;
            }
            set
            {
                retryConnectionAfter = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(RetryConnectionAfter)));
            }
        }

        private bool includeDeviceName;
        public bool IncludeDeviceName
        {
            get
            {
                return includeDeviceName;
            }
            set
            {
                includeDeviceName = value;
                InvokePropertyChanged(new PropertyChangedEventArgs(nameof(IncludeDeviceName)));
            }
        }

        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
