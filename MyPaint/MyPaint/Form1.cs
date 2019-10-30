using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            drawing = !drawing;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                pictureBox1.Image = bmp;
            }
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void LimeButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Lime;
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void BlackButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "JPeg Image|*.jpg|Bitmap Image *.bmp|",
                Title = "Save an Image File"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
            }
        }
    }
}
