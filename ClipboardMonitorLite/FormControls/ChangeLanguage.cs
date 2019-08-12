using System;
using ClipboardMonitorLite.Languages;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.FormControls
{
    public class Language
    {
        private ResourceManager resManager;
        public void Change(LanguageCode.Language language)
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[(int)language]}",
            Assembly.GetExecutingAssembly());
        }
    }
}
