using System;
using System.Diagnostics;
using System.IO;

namespace ClipboardLibrary
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
            try
            {
                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    await sw.WriteLineAsync(clipboardContent.LastCopied);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
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
                Debug.WriteLine(ex.Message);
            }
        }

        public string Format()
        {
            return $"{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_ClipboardHistory.txt";
        }
    }
}
