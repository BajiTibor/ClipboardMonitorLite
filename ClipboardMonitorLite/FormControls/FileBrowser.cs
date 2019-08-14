using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.FormControls
{
    public class FileBrowser
    {
        private SaveFileDialog _dialog;
        public FileBrowser(SaveFileDialog dialog)
        {
            _dialog = dialog;
        }
        public void Btn_browse_Click(object sender, EventArgs e)
        {

        }
    }
}
