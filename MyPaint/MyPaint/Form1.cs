/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 6: Create your own Drawing Paint App
 * */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        // defint the public bitmap, pen and drawing variable.
        Bitmap bmp = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The function that executes when the mouse pointer is over the picture box component and the mouse button is pressed and/or released.
        /// </summary>
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // inverse the "drawing" variable every time when mouse is over the picture and the button is pressed or released.
            drawing = !drawing;
        }

        /// <summary>
        /// The function that executes when the mouse is moved.
        /// </summary>
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // draw the ellipse if the "drawing" variable is true.
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                pictureBox1.Image = bmp;
            }
        }

        /// <summary>
        /// The function that executes when "Red" button is clicked.
        /// </summary>
        private void RedButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        /// <summary>
        /// The function that executes when "Blue" button is clicked.
        /// </summary>
        private void BlueButton_Click(object sender, EventArgs e)
        {
            // set the public pen color to blue.
            p.Color = Color.Blue;
        }

        /// <summary>
        /// The function that executes when "Green" button is clicked.
        /// </summary>
        private void GreenButton_Click(object sender, EventArgs e)
        {
            // set the public pen color to green.
            p.Color = Color.Green;
        }

        /// <summary>
        /// The function that executes when "Purple" button is clicked.
        /// </summary>
        private void PurpleButton_Click(object sender, EventArgs e)
        {
            // set the public pen color to purple.
            p.Color = Color.Purple;
        }

        /// <summary>
        /// The function that executes when "Lime" button is clicked.
        /// </summary>
        private void LimeButton_Click(object sender, EventArgs e)
        {
            // set the public pen color to lime.
            p.Color = Color.Lime;
        }

        /// <summary>
        /// The function that executes when "White" button is clicked.
        /// </summary>
        private void WhiteButton_Click(object sender, EventArgs e)
        {
            // set the public pen color to white.
            p.Color = Color.White;
        }

        /// <summary>
        /// The function that executes when "Black" button is clicked.
        /// </summary>
        private void BlackButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        /// <summary>
        /// The function that executes when "Save as" menu item is selected.
        /// </summary>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                // Defining two filters for saving and title.
                Filter = "JPeg Image|*.jpg|Bitmap Image *.bmp|",
                Title = "Save an Image File"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    // If the first filter is selected.
                    case 1:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    // If the second filter is selected.
                    case 2:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
            }
        }
    }
}
