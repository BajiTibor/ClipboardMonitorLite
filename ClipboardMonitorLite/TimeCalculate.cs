using System;

namespace ClipboardMonitorLite
{
    class TimeCalculate
    {
        public DateTime TargetDate { get; set; }

        public void CalculateToSeconds(int time, string format)
        {
            int tempTime = 0;
            switch (format)
            {
                case "Seconds":
                    tempTime = time;
                    break;
                case "Minutes":
                    tempTime = time * 60;
                    break;
                case "Hours":
                    tempTime = time * 3600;
                    break;
                default:
                    tempTime = 0;
                    break;
            }
            TargetDate = DateTime.Now.AddSeconds(tempTime);
        }
    }
}
