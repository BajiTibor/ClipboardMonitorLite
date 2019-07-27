using System;
using System.Diagnostics;

namespace ClipboardMonitorLite
{
    public class Donate
    {
        public void Btn_Donate_Click(object sender, EventArgs e)
        {
            Process.Start(Constants.PayPalLink);
        }
    }
}
