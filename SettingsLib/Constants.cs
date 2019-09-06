using System;

namespace SettingsLib
{
    public static class Constants
    {
        public static string DefaultHistoryFileDirectory = 
            $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_history.txt";
        public static string MachineName = Environment.MachineName;
    }
}
