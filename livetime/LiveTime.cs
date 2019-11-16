using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livetime
{
    class LiveTime : TextBox
    {

        private System.Windows.Forms.Timer timer1;
        
        private string timeformat = "HH:mm:ss";
        DateTime timeUtc = DateTime.UtcNow;

        public LiveTime()
        {

            this.ReadOnly = true;
            
            this.TimeZone = TimeZoneInfo.Local;
            
            DisplayTime();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;            
            timer1.Tick += Timer1_Tick;
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DisplayTime();
        }

        public TimeZoneInfo TimeZone { get; set; }

        public string Format { get { return timeformat; } set { timeformat = value; } }

        private void DisplayTime()
        {            
            timeUtc = DateTime.UtcNow;
            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, this.TimeZone);
            this.Text = cstTime.ToString(timeformat);
        }
    }
}
