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
    public partial class clock : Form
    {
        Timer t = new Timer();
        
        public clock()
        {
            InitializeComponent();
        }

        private void clock_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.TimerTick);
            t.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {

        }
    }
}
