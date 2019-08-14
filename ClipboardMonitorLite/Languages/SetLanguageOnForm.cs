using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using ClipboardMonitorLite.FormControls;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipboardMonitorLite.SettingsManager;

namespace ClipboardMonitorLite.Languages
{
    public class SetLanguageOnForm
    {
        private Settings _settings;
        private FormControl _controls;
        private ResourceManager _resManager;
        public void SetLang(Settings settings, Form CurrentForm)
        {
            _controls = new FormControl();
            _settings = settings;
            _resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[_settings.CurrentlySelectedLanguage]}",
                Assembly.GetExecutingAssembly());
            foreach (var item in _controls.GetAllControl(CurrentForm))
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
