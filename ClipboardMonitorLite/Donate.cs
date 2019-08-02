using System;
using System.Diagnostics;

namespace ClipboardMonitorLite
{
    public class Donate
    {
        ExceptionHandling ExHandler;
        public Donate()
        {
            ExHandler = new ExceptionHandling();
        }

        public void Btn_Donate_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.KoFiLink);
            }
            catch (Exception ex)
            {
                ExHandler.Error(ex);
            }
        }
    }
}
