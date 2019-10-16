using System;
using CloudConnectionLib;
using System.Windows.Forms;

namespace ClipboardMonitorLite.Cloud
{
    /// <summary>
    /// Object that checks a static variable every time the timer that
    /// was bassed to it elapses, because WinForms doesn't respect
    /// INotifyPropertyChanged across threads.
    /// </summary>

    //This just sounds bad, what does it even do?
    public class CheckStaticConnectionState
    {
        private Label ConnectionLabel;
        private Timer MainTimer;
        public CheckStaticConnectionState(Label label, Timer timer)
        {
            ConnectionLabel = label;
            MainTimer = timer;
            MainTimer.Start();
            MainTimer.Tick += TimerElapsed;
        }

        private void TimerElapsed(object sender, EventArgs e)
        {
            ConnectionLabel.Text = OnlineState.ConnectionLife;
        }
    }
}
