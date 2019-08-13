using System;
using System.IO;
using Newtonsoft.Json;
using ClipboardMonitorLite.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.SettingsManager
{
    public class HandleSettings
    {
        public async void WriteSettingsFile(string jsonFile)
        {
            if (!Directory.Exists(Constants.SettingsDirectory))
            {
                try
                {
                    Directory.CreateDirectory(Constants.SettingsDirectory);
                }
                catch
                {

                }
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(Constants.SettingsFilePath))
                {
                    await sw.WriteLineAsync(jsonFile);
                }
            }
            catch
            {

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
            catch
            {

            }
            return tempSettings;
        }


    }
}
