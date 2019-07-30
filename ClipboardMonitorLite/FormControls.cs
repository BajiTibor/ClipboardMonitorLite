using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public class FormControls
    {
        public List<Control> AllControl(Control parent)
        {
            List<Control> list = new List<Control>();
            foreach (Control item in parent.Controls)
            {
                if (item is GroupBox)
                {
                    list.AddRange(AllControl(item));
                }
                list.Add(item);
            }
            return list;
        }
    }
}
