/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 2: Create a Music Player
 * */

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

        /// <summary>
        /// This function resets the style of all control buttons to "Regular"
        /// </summary>
        private void AllControlsFontsToRegular()
        {
            buttonBrowse.Font = new Font(buttonBrowse.Font, FontStyle.Regular);
            buttonPlay.Font = new Font(buttonPlay.Font, FontStyle.Regular);
            buttonPause.Font = new Font(buttonPause.Font, FontStyle.Regular);
            buttonStop.Font = new Font(buttonStop.Font, FontStyle.Regular);
            buttonExit.Font = new Font(buttonExit.Font, FontStyle.Regular);
        }

        /// <summary>
        /// This function starts when the "Browse" button is clicked
        /// </summary>
        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            // Set the font style of all controls to "Regular"
            AllControlsFontsToRegular();

            // Set the style of the last clicked button to "Bold"
            buttonBrowse.Font = new Font(buttonBrowse.Font, FontStyle.Bold);

            // If the files with proper extension are selected
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
               // Add those files to the list
               foreach (String file in openFileDialog1.FileNames)
                     listBox1.Items.Add(file);
        }

        /// <summary>
        /// This function starts when the "Play" button is clicked
        /// </summary>
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            // Set the font style of all controls to "Regular"
            AllControlsFontsToRegular();

            // Set the style of the last clicked button to "Bold"
            buttonPlay.Font = new Font(buttonPlay.Font, FontStyle.Bold);

            // Start the player
            Player.Ctlcontrols.play();

            // Set the Pause Button text to "Pause" (just in case that there is some other text)
            buttonPause.Text = "Pause";
        }

        /// <summary>
        /// This function starts when the "Pause" button is clicked
        /// </summary>
        private void ButtonPause_Click(object sender, EventArgs e)
        {
            // Set the font style of all controls to "Regular"
            AllControlsFontsToRegular();

            // Set the style of the last clicked button to "Bold"
            buttonPause.Font = new Font(buttonPause.Font, FontStyle.Bold);

            // If the Player is playing
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Pause the Player
                Player.Ctlcontrols.pause();

                // Set the button text to "Resume"
                buttonPause.Text = "Resume";
            }
            // Else If player is paused
            else if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                // Start the Player
                Player.Ctlcontrols.play();

                // Set the button text to "Pause"
                buttonPause.Text = "Pause";
            }
        }

        /// <summary>
        /// This function starts when the "Stop" button is clicked
        /// </summary>
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            // Set the font style of all controls to "Regular"
            AllControlsFontsToRegular();

            // Set the style of the last clicked button to "Bold"
            buttonStop.Font = new Font(buttonStop.Font, FontStyle.Bold);

            // Stop the player
            Player.Ctlcontrols.stop();
        }

        /// <summary>
        /// This function starts when the "Exit" button is clicked
        /// </summary>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            // Set the style of the "Exit" button to "Bold"
            buttonExit.Font = new Font(buttonExit.Font, FontStyle.Bold);

            // Close the app
            Close();
        }

        /// <summary>
        /// This function starts when some song in listBox is clicked
        /// </summary>
        private void listBox1_Click(object sender, EventArgs e)
        {
            Player.URL = listBox1.GetItemText(listBox1.SelectedItem);

            // Set the font style of all controls to "Regular"
            AllControlsFontsToRegular();

            // Set the style of the "Play" button to "Bold" cause the player is adjusted as auto-start.
            buttonPlay.Font = new Font(buttonPlay.Font, FontStyle.Bold);
        }
    }
}
