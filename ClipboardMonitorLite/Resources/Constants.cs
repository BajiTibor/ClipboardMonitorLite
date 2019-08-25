using System;

namespace ClipboardMonitorLite.Resources
{
    public static class Constants
    {
        public static string SettingsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardManagerLite\settings.json";
        public static string SettingsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardManagerLite";
        public static string DefaultHistoryFileDirectory = 
            $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_history.txt";
    }
}
