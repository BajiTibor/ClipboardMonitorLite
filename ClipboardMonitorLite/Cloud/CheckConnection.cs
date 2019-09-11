using CloudConnectionLib;
using System.Windows.Forms;
using System.Threading.Tasks;
using System;

namespace ClipboardMonitorLite.Cloud
{
    public class CheckConnection
    {
        private Label ConnectionLabel;
        private Timer MainTimer;
        public CheckConnection(Label label, Timer timer)
        {
            ConnectionLabel = label;
            MainTimer = timer;
            MainTimer.Start();
            MainTimer.Tick += TimerElapsed;

            //Task.Factory.StartNew(() => SetConnectionLabel(), TaskCreationOptions.LongRunning);

        }

        private async Task SetConnectionLabel()
        {
            while (true)
            {
                ConnectionLabel.Text = OnlineState.ConnectionLife;
                await Task.Delay(2500);
            }
        }

        private void TimerElapsed(object sender, EventArgs e)
        {
            ConnectionLabel.Text = OnlineState.ConnectionLife;
        }
    }
}
