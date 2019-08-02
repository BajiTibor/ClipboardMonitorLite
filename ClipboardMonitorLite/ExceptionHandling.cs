using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ClipboardMonitorLite
{
    public class ExceptionHandling
    {
        public void Critical(Exception e)
        {
            MessageBox.Show(e.Message, "Critical error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Error(Exception e)
        {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Silent(Exception e)
        {
            Debug.WriteLine(e.Message);
        }
    }
}
