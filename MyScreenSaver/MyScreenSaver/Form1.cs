/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 3: Create Screen Saver
 * */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class FrmScSaver : Form
    {
        // List of all images
        List<Image> BGImages = new List<Image>();

        // List of all BritPic classes
        List<BritPic> BritPics = new List<BritPic>();

        // Generate random number
        Random rand = new Random();

        // Class for every picture. Picture is represented by number cause there is same size list of all pictures.
        class BritPic
        {
            public int PicNum;
            public float X;
            public float Y;
        }

        public FrmScSaver()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function that close the app when any key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmScSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }


        // function that make all the necessary operations when the the app is started (the form is loaded)
        private void FrmScSaver_Load(object sender, EventArgs e)
        {
            // Array of all path to the images in specified folder
            string[] images = System.IO.Directory.GetFiles("pics");

            // For each picture in path list
            foreach (string image in images)
            {
                // Add it to the BGImages list
                BGImages.Add(new Bitmap(image)); 
            }

            // Loop that some amount of pictures
            for (int i = 0; i < 100; ++i)
            {
                BritPic mp = new BritPic
                {
                    // If the number is larger then count of images start from the beggining
                    PicNum = i % BGImages.Count,

                    // Get the random X coordinates
                    X = rand.Next(0, Width),

                    // Get the random Y coordinates
                    Y = rand.Next(0, Height)
                };

                // Add that structure to the BritPic class list
                BritPics.Add(mp);
            }
        }

        /// <summary>
        /// Function that redraw itself on every timer1 Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        /// <summary>
        /// Function that draw all images in the BritPics List.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmScSaver_Paint(object sender, PaintEventArgs e)
        {
            // for every picture class
            foreach (BritPic bp in BritPics)
            {
                // draw the one picture
                e.Graphics.DrawImage(BGImages[bp.PicNum], bp.X, bp.Y);
                
                // move position of the picture for 5 pixels to the left
                bp.X -= 5;

                // if the picture is to far left
                if (bp.X < -250)
                {
                    // move that picture to the new X position
                    bp.X = Width + rand.Next(20, 100);
                }
            }
        }
    }
}
