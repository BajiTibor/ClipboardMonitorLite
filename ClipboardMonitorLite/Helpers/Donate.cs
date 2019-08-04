using System;
using System.Diagnostics;

namespace ClipboardLibrary
{
    public class Donate
    {
        public Donate()
        {
        }

        public void Btn_Donate_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Constants.KoFiLink);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
