using System;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using ClipboardMonitorLite.ClipboardActions;


namespace ClipboardMonitorLite.FileOperations
{
    public class SaveHistory
    {
        ClipboardManager ClipManager;
        public SaveHistory(ClipboardManager clipManager)
        {
            ClipManager = clipManager;
            ClipManager.PropertyChanged += ClipManager_PropertyChanged;
        }

        private async void ClipManager_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("CurrentlyCopiedItem"))
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        await sw.WriteLineAsync(ClipManager.CurrentlyCopiedItem);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        private async void CheckFilePresence()
        {
            if (FilePath.Equals("EMPTY"))
            {
                // Set the settings to be a new file
            }
        }

        public string FilePath { get; set; }

        public string FileNameFormat()
        {
            return $"{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_ClipboardHistory.txt";
        }
    }
}
