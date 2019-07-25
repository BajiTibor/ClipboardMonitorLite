using System;

namespace ClipboardMonitorLite
{
    public class Filename
    {
        public string Format()
        {
            return $"{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_ClipboardHistory.txt";
        }
    }
}
