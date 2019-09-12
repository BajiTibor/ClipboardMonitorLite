using Newtonsoft.Json;

namespace SettingsLib
{
    /// <summary>
    /// Class that creates a Json file from the Settings object.
    /// </summary>
    public class CreateJsonFile
    {
        private SettingsHandler _settingsManager;
        public CreateJsonFile()
        {
            _settingsManager = new SettingsHandler();
        }

        public void CreateFile(Settings _settings)
        {
            if (!_settings.Equals(null))
            {
                string converted = JsonConvert.SerializeObject(_settings, Formatting.Indented);
                _settingsManager.WriteSettingsFile(converted);
            }
        }
    }
}
