using System;
using System.Windows.Forms;

//I think this and HistoryFile could be merged into something like
//HistoryManager, code would be a bit cleaner.

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

        //Why full prop for this?
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
