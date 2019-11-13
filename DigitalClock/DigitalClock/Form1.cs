/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 10: Create Digital Clock Showing Date and Day
 * */


using System;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMinuteLabel.Text = DateTime.Now.ToString("HH:mm");
            secondsLabel.Text = DateTime.Now.ToString("ss");
            dateLabel.Text = DateTime.Now.ToString("MMM/dd/yyyy");
            weekDayLabel.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
