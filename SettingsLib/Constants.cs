using System;

namespace SettingsLib
{
    /// <summary>
    /// Constants that gets pulled from the user's Environment 
    /// and won't be modified, mostly used as a fallback, default value.
    /// </summary>

    //Perhaps move this into settings file instead of keeping Constants as separate class?
    public static class Constants
    {
        public static string DefaultHistoryFileDirectory = 
            $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss")}_history.txt";
        public static string MachineName = Environment.MachineName;
    }
}
