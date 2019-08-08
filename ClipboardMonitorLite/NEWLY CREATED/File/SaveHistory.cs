using System;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;

namespace ClipboardMonitorLite
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

        public string FilePath { get; set; }

        
    }
}
