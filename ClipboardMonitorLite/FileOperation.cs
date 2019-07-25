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

        public void WriteToFile(VirtualClipboard clipboardContent)
        {
            if (Properties.Settings.Default.AppendFile)
            {
                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    sw.WriteLineAsync(clipboardContent.LastCopied);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(FilePath))
                {
                    sw.WriteLineAsync(clipboardContent.LastCopied);
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
    }
}
