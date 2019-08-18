﻿using System.Windows.Forms;
using System.ComponentModel;

namespace ClipboardMonitorLite.SettingsManager
{
    public class Settings : INotifyPropertyChanged
    {
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

        FormWindowState startState;
        public FormWindowState StartupWindowState
        {
            get
            {
                return startState;
            }
            set
            {
                startState = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("StartupWindowState"));
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

        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}