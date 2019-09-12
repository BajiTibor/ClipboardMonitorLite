using System.Windows.Forms;
using System.Collections.Generic;

namespace ClipboardMonitorLite.FormControls
{
    /// <summary>
    /// Object that contains a method that can fetch most
    /// Controls from a form that can be translated.
    /// </summary>
    public class FormControl
    {
        public List<Control> GetControlsForTranslation(Control parent)
        {
            List<Control> list = new List<Control>();
            foreach (Control item in parent.Controls)
            {
                if (item is Label || item is GroupBox || item is Button || item is CheckBox || item is RadioButton)
                {
                    if (item is GroupBox)
                    {
                        list.AddRange(GetControlsForTranslation(item));
                    }
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
