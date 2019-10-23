/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 5: Create a Picture Viewer
 * */

using System;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function that will be started when the "Close" button is clicked.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Close the Form.
            this.Close();
        }

        /// <summary>
        /// Function that will be started when the "Background" button is clicked.
        /// </summary>
        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        /// <summary>
        /// Function that will be started when the "Clear" button is clicked.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
        }

        /// <summary>
        /// Function that will be started when the "Show" button is clicked.
        /// </summary>
        private void ShowButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user click OK, load the
            // picture that user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
        }

        /// <summary>
        /// Function that will be started when the state of the only CheckBox is changed.
        /// </summary>
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears
            // the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
