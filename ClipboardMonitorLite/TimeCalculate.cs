using System;

namespace ClipboardMonitorLite
{
    class TimeCalculate
    {
        private readonly int FallbackValue = 0;
        private int Time
        {
            get
            {
                return FallbackValue;
            }
            set
            {
                TargetDate = DateTime.Now.AddSeconds(Time);
            }
        }
        public DateTime TargetDate { get; set; }

        public void CalculateToSeconds(int time, string format)
        {
            switch (format)
            {
                case "Seconds":
                    Time = time;
                    break;
                case "Minutes":
                    Time = time * 60;
                    break;
                case "Hours":
                    Time = time * 3600;
                    break;
                default:
                    Time = 0;
                    break;
            }
        }
    }
}
