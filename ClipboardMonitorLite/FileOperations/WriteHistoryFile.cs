using System;
using System.IO;
using SettingsLib;
using System.Diagnostics;
using System.ComponentModel;
using ClipboardMonitorLite.ClipboardActions;

namespace ClipboardMonitorLite.FileOperations
{
    /// <summary>
    /// Writes the history file, either in real time, or when the user
    /// exist the application.
    /// </summary>
    public class WriteHistoryFile
    {
        private Settings _settings;
        public string FilePath { get; set; }
        private ClipboardManager _clipboardManager;

        public WriteHistoryFile(ClipboardManager clipManager, Settings settings)
        {
            _clipboardManager = clipManager;
            _settings = settings;
            FilePath = _settings.HistoryFileLocation;
            _clipboardManager.PropertyChanged += SaveNewItem;
            _settings.PropertyChanged += HistoryFileLocationChanged;
            InitialFilePath();
        }

        private void HistoryFileLocationChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("HistoryFileLocation"))
            {
                if (string.IsNullOrWhiteSpace(_settings.HistoryFileLocation))
                    _settings.HistoryFileLocation = Constants.DefaultHistoryFileDirectory;
                FilePath = _settings.HistoryFileLocation;
            }
        }

        private async void SaveNewItem(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("CurrentlyCopiedItem") && _settings.WriteInRealTime)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        await sw.WriteLineAsync(_clipboardManager.CurrentlyCopiedItem);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public void WriteBeforeExit()
        {
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                sw.WriteLine(_clipboardManager.ClipboardHistory);
            }
        }

        private void InitialFilePath()
        {
            if (string.IsNullOrEmpty(_settings.HistoryFileLocation))
            {
                _settings.HistoryFileLocation = Constants.DefaultHistoryFileDirectory;
            }
        }
    }
}
