using System.Resources;
using System.Reflection;
using System.Windows.Forms;
using ClipboardMonitorLite.FormControls;
using SettingsLib;

namespace ClipboardMonitorLite.Languages.LanguageControl
{
    /// <summary>
    /// Sets the language on the form passed to it.
    /// Generates a new Resource manager based on the Settings object
    /// that's passed to it.
    /// </summary>
    public class LanguageOnForm
    {
        private Settings _settings;
        private FormControl _formControl;
        private ResourceManager _resManager;
        public void SetLang(Settings settings, Form CurrentForm)
        {
            _formControl = new FormControl();
            _settings = settings;
            _resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[_settings.CurrentlySelectedLanguage]}",
                Assembly.GetExecutingAssembly());

            foreach (var item in _formControl.GetControlsForTranslation(CurrentForm))
            {
                if (!(item is ComboBox) && !(item.Name.Contains("DONOTMODIFY") && !(item is RichTextBox)))
                {
                    item.Text = _resManager.GetString(item.Name);
                }
            }
            CurrentForm.Text = _resManager.GetString("Main_Title");
        }
    }
}
