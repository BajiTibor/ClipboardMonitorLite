using System;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using System.ComponentModel;

namespace SettingsLib
{
    /// <summary>
    /// Object that handles finding, loading or writing the settings.json file to
    /// the AppData directory.
    /// </summary>
    public class SettingsHandler
    {
        private string appDataDirectory;
        private string settingsDirectory;
        private string settingsFilePath;
        private string onlineSettingsFilePath;
        public SettingsHandler()
        {
            appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            settingsDirectory = appDataDirectory + @"\ClipboardManagerLite";
            settingsFilePath = appDataDirectory + @"\ClipboardManagerLite\settings.json";
            onlineSettingsFilePath = settingsDirectory + @"\onlineSettings.json";
        }

        public async void WriteSettingsFile(string jsonFile, bool isOnlineFile = false)
        {
            if (!Directory.Exists(settingsDirectory))
            {
                try
                {
                    Directory.CreateDirectory(settingsDirectory);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
            try
            {
                var fileToWrite = isOnlineFile ? onlineSettingsFilePath : settingsFilePath;
                using (StreamWriter sw = new StreamWriter(fileToWrite))
                {
                    await sw.WriteLineAsync(jsonFile);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public IAppSettings LoadSettingsFile(bool isOnlineFile = false)
        {
            IAppSettings tempSettings = null;
            var FileToLoad = isOnlineFile ? onlineSettingsFilePath : settingsFilePath;
            if (File.Exists(FileToLoad))
            {
                try
                {
                    IAppSettings OnlineSettings = new OnlineInformation();
                    IAppSettings LocalSettings = new Settings();

                    if (isOnlineFile)
                    {
                        OnlineSettings = JsonConvert.DeserializeObject<OnlineInformation>(File.ReadAllText(FileToLoad));
                        tempSettings = OnlineSettings;
                    }
                    else
                    {
                        LocalSettings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(FileToLoad));
                        tempSettings = LocalSettings;
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
            return tempSettings;
        }

        public void CreateFile(IAppSettings _settings)
        {
            if (!_settings.Equals(null))
            {
                string converted = JsonConvert.SerializeObject(_settings, Formatting.Indented);
                if (_settings.Type.Equals("UserSettings"))
                {
                    WriteSettingsFile(converted);
                }
                else
                {
                    WriteSettingsFile(converted, true);
                }

            }
        }
    }
}
