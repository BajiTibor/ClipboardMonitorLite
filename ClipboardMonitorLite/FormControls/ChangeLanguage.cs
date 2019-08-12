using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

//This class is inside the FormControls folder right?
//ClipboardMonitorLite is the project name
//So for clarity, namespace should be
//  ClipboardMonitorLite.FormControls
//If you use that, you know where to find it in project
//Because otherwise, you'll have a lot of duplicate class names 
//and you won't exactly know where to look for class
//Besides, your class name is Language and file name is ChangeLanguage
//That only adds more to confusion
//Namespace for biggest clarity should be the path where to find the file
//Class name should be exact same as the filename
namespace ClipboardMonitorLite
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
