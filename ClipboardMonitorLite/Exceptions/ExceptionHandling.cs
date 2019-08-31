using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ClipboardMonitorLite.Exceptions
{
    public class ExceptionHandling
    {
        public void Handle(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            Debug.WriteLine($"BEGINNING OF ERROR REPORT\n" +
                $"{ex.Message}\n\n{ex.StackTrace}\n\n{ex.InnerException}\n" +
                $"END OF ERROR REPORT");
        }
    }
}
