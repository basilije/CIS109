using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDigitalClock
{
    public partial class Clock : Form
    {
        Timer t = new Timer();
        
        public Clock()
        {
            InitializeComponent();
        }

        private void ClockLoad(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.TimerTick);
            t.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            time += hh < 10 ? "0" + hh.ToString() : hh.ToString();
            time += ":";
            time += mm < 10 ? "0" + mm.ToString() : mm.ToString();
            time += ":";
            time += ss < 10 ? "0" + ss.ToString() : ss.ToString();

            label1.Text = time;
        }
    }
}
