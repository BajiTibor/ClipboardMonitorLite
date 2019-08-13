using System;
using Newtonsoft.Json;
using ClipboardMonitorLite.FileOperations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.SettingsManager
{
    public class CreateJsonFile
    {
        Settings Settings;
        public CreateJsonFile(Settings settings)
        {
            Settings = settings;
            
        }

        public void CreateFile()
        {
            string converted = JsonConvert.SerializeObject(Settings);

        }

        private string SettingsFileLocation()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\AppSettings\\ClipboardManagerLite\\settings.json";
        }
    }
}
