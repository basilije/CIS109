/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 11: Create a Simple Digital Clock
 * */

using System;
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

            label1.Text = (hh < 10 ? "0" : "") + hh.ToString() + ":" + (mm < 10 ? "0" : "") + mm.ToString() + ":" + (ss < 10 ? "0" : "") + ss.ToString();

        }
    }
}
