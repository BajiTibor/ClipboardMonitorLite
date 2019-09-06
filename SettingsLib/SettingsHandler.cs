﻿using System;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace SettingsLib
{
    public class SettingsHandler
    {
        private string appDataDirectory;
        private string settingsFilePath;
        private string settingsDirectory;
        public SettingsHandler()
        {
            appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            settingsDirectory = appDataDirectory + @"\ClipboardManagerLite";
            settingsFilePath = appDataDirectory + @"\ClipboardManagerLite\settings.json";
        }
        
        public async void WriteSettingsFile(string jsonFile)
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
                using (StreamWriter sw = new StreamWriter(settingsFilePath))
                {
                    await sw.WriteLineAsync(jsonFile);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public Settings LoadSettingsFile()
        {
            Settings tempSettings = new Settings();
            if (File.Exists(settingsFilePath))
            {
                try
                {
                    Settings settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsFilePath));
                    tempSettings = settings;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
            return tempSettings;
        }
    }
}
