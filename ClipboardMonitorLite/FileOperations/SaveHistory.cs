using System;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using ClipboardMonitorLite.Resources;
using ClipboardMonitorLite.SettingsManager;
using ClipboardMonitorLite.ClipboardActions;

namespace ClipboardMonitorLite.FileOperations
{
    public class SaveHistory
    {
        public string FilePath { get; set; }
        ClipboardManager _clipManager;
        private Settings _settings;
        public SaveHistory(ClipboardManager clipManager, Settings settings)
        {
            _clipManager = clipManager;
            _settings = settings;
            FilePath = _settings.HistoryFileLocation;
            _clipManager.PropertyChanged += SaveNewItem;
            _settings.PropertyChanged += _settings_PropertyChanged;
            InitialFilePath();
        }

        private void _settings_PropertyChanged(object sender, PropertyChangedEventArgs e)
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
                        await sw.WriteLineAsync(_clipManager.CurrentlyCopiedItem);
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
                sw.WriteLine(_clipManager.ClipboardHistory);
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
