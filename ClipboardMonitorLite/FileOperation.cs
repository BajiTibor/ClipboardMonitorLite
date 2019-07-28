using System;
using System.IO;

namespace ClipboardMonitorLite
{
    public class FileOperation
    {
        public string FilePath { get; set; }

        public FileOperation(string filepath)
        {
            FilePath = filepath;
        }

        public async void WriteToFile(VirtualClipboard clipboardContent)
        {
                if (Properties.Settings.Default.AppendFile)
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        await sw.WriteLineAsync(clipboardContent.LastCopied);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(FilePath))
                    {
                        await sw.WriteLineAsync(clipboardContent.LastCopied);
                    }
                }

        }

        public void WriteBeforeClosing(VirtualClipboard clipboardContent)
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(clipboardContent.History);
            }
        }

        public string Format()
        {
            return $"{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_ClipboardHistory.txt";
        }
    }
}
