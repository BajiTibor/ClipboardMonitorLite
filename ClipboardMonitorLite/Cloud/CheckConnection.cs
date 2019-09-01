﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.Cloud
{
    public class CheckConnection
    {
        private Timer CheckTimer;
        private Label ConnectionLabel;
        public CheckConnection(Timer timer, Label label)
        {
            CheckTimer = timer;
            ConnectionLabel = label;
            CheckTimer.Start();
            CheckTimer.Tick += TimeElapsed;
        }

        private void TimeElapsed(object sender, EventArgs e)
        {
            ConnectionLabel.Text = onState.ConnectionLife.ToString();
        }
    }
}
