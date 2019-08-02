using System;
using System.IO;

namespace ClipboardMonitorLite
{
    public class FileOperation
    {
        ExceptionHandling ExHandler;
        public string FilePath { get; set; }

        public FileOperation(string filepath)
        {
            FilePath = filepath;
            ExHandler = new ExceptionHandling();
        }

        public async void WriteToFile(VirtualClipboard clipboardContent)
        {
            try
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
            catch (Exception ex)
            {
                ExHandler.Silent(ex);
            }   
        }

        public void WriteBeforeClosing(VirtualClipboard clipboardContent)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FilePath))
                {
                    sw.WriteLine(clipboardContent.History);
                }
            }
            catch (Exception ex)
            {
                ExHandler.Error(ex);
            }
        }

        public string Format()
        {
            return $"{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_ClipboardHistory.txt";
        }
    }
}
