﻿using Newtonsoft.Json;

namespace ClipboardMonitorLite.SettingsManager
{
    public class CreateJsonFile
    {
        private HandleSettings _saveSettings;
        public CreateJsonFile()
        {
            _saveSettings = new HandleSettings();
        }

        public void CreateFile(Settings _settings)
        {
            string converted = JsonConvert.SerializeObject(_settings, Formatting.Indented);
            _saveSettings.WriteSettingsFile(converted);
        }

    }
}