using System;
using System.Windows.Forms;

namespace ClipboardMonitorLite.ClipboardActions
{
    public class AutoHistoryCleaner
    {
        private Timer Timer;
        private int clearInterval;
        private ClipboardManager _clipManager;
        public AutoHistoryCleaner(ClipboardManager Clip, Timer timer)
        {
            _clipManager = Clip;
            Timer = timer;
        }

        public int ClearInterval
        {
            get
            {
                return clearInterval;
            }
            set
            {
                clearInterval = value;
                StartTimer(value);
            }
        }

        private void StartTimer(int time)
        {
            if (!time.Equals(0))
            {
                Timer.Interval = time * 6000; // Convert from minutes to milliseconds
                Timer.Start();
                Timer.Tick += OnElapsed;
            }
            else
                Timer.Stop();
        }
        private void OnElapsed(object sender, EventArgs e)
        {
            _clipManager.ClearHistory();
        }
    }
}
