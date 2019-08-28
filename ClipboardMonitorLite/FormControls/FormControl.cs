using System.Windows.Forms;
using System.Collections.Generic;

namespace ClipboardMonitorLite.FormControls
{
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
