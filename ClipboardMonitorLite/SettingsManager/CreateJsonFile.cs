using Newtonsoft.Json;

namespace ClipboardMonitorLite.SettingsManager
{
    public class CreateJsonFile
    {
        private Settings _settings;
        private HandleSettings _saveSettings;
        public CreateJsonFile(Settings settings)
        {
            _settings = settings;
            _saveSettings = new HandleSettings();
        }

        public void CreateFile()
        {
            string converted = JsonConvert.SerializeObject(_settings, Formatting.Indented);
            _saveSettings.WriteSettingsFile(converted);
        }

    }
}
