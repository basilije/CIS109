using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
               foreach (String file in openFileDialog1.FileNames)
                     listBox1.Items.Add(file);
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
            buttonPause.Text = "Pause";
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Player.Ctlcontrols.pause();
                buttonPause.Text = "Resume";
            }
            else if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            { 
                Player.Ctlcontrols.play();
                buttonPause.Text = "Pause";
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Player.URL = listBox1.GetItemText(listBox1.SelectedItem);
        }
    }
}
