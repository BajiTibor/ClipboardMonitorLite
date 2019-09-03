using System;
using System.IO;
using System.ComponentModel;
using ClipboardMonitorLite.Resources;
using ClipboardMonitorLite.Exceptions;
using ClipboardMonitorLite.SettingsManager;
using ClipboardMonitorLite.ClipboardActions;

namespace ClipboardMonitorLite.FileOperations
{
    public class WriteHistoryFile
    {
        private Settings _settings;
        public string FilePath { get; set; }
        private ClipboardManager _clipboardManager;
        private ExceptionHandling _exceptionHandler;

        public WriteHistoryFile(ClipboardManager clipManager, Settings settings)
        {
            _exceptionHandler = new ExceptionHandling();
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
                    _exceptionHandler.Handle(ex);
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
