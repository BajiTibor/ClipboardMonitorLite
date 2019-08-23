using System;
using System.IO;
using Newtonsoft.Json;
using ClipboardMonitorLite.Resources;
using ClipboardMonitorLite.Exceptions;

namespace ClipboardMonitorLite.SettingsManager
{
    public class HandleSettings
    {
        private ExceptionHandling _exceptions;
        public HandleSettings()
        {
            _exceptions = new ExceptionHandling();
        }
        
        public async void WriteSettingsFile(string jsonFile)
        {
            if (!Directory.Exists(Constants.SettingsDirectory))
            {
                try
                {
                    Directory.CreateDirectory(Constants.SettingsDirectory);
                }
                catch (Exception e)
                {
                    _exceptions.Handle(e);
                }
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(Constants.SettingsFilePath))
                {
                    await sw.WriteLineAsync(jsonFile);
                }
            }
            catch (Exception e)
            {
                _exceptions.Handle(e);
            }
        }

        public Settings LoadSettingsFile()
        {
            Settings tempSettings = new Settings();
            try
            {
                Settings settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Constants.SettingsFilePath));
                tempSettings = settings;
            }
            catch (Exception e)
            {
                _exceptions.Handle(e);
            }
            return tempSettings;
        }
    }
}
