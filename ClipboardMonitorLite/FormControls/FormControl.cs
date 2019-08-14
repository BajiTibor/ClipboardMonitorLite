using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClipboardMonitorLite.FormControls
{
    public class FormControl
    {
        private Form CurrentForm;
        public List<Control> GetAllControl(Control parent) //That's a lie, only a few that can be translated
        {
            List<Control> list = new List<Control>();
            foreach (Control item in parent.Controls)
            {
                if (item is Label || item is GroupBox || item is Button || item is CheckBox || item is RadioButton)
                {
                    if (item is GroupBox)
                    {
                        list.AddRange(GetAllControl(item));
                    }
                    list.Add(item);
                }
            }
            return list;
        }

        public Form GetLastFormInteractedWith()
        {
            if (CurrentForm == null)
            {
                CurrentForm = Application.OpenForms.Cast<Form>().FirstOrDefault();
            }
            else
            {
                return CurrentForm;
            }
            return CurrentForm;
        }
    }
}
