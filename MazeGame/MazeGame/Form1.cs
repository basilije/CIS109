/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 3: Create a Maze Game
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

namespace MazeGame
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
        System.Media.SoundPlayer firstColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring01.wav");
        System.Media.SoundPlayer secondColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring02.wav");
        System.Media.SoundPlayer thirdColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring03.wav");
        System.Media.SoundPlayer fourthColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring04.wav");
        System.Media.SoundPlayer fifthColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring05.wav");
        System.Media.SoundPlayer sixthColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring06.wav");
        System.Media.SoundPlayer seventhColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring07.wav");
        System.Media.SoundPlayer eighthColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring08.wav");
        System.Media.SoundPlayer ninthColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring09.wav");
        System.Media.SoundPlayer tenthColorSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring10.wav");


        public Form1()
        {
            InitializeComponent();
            startSoundPlayer.Play();
            MovetoStart();
        }

        private void LabelFinish_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!");
            Close();
        }

        private void MovetoStart()
        {
            
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            MovetoStart();
        }

        private void FirstColorWall_MouseEnter(object sender, EventArgs e)
        {
            firstColorSoundPlayer.Play();
            MovetoStart();
        }

        private void SecondColorWall_MouseEnter(object sender, EventArgs e)
        {
            secondColorSoundPlayer.Play();
            MovetoStart();
        }

        private void ThirdColorWall_MouseEnter(object sender, EventArgs e)
        {
            thirdColorSoundPlayer.Play();
            MovetoStart();
        }

        private void FourthColorWall_MouseEnter(object sender, EventArgs e)
        {
            fourthColorSoundPlayer.Play();
            MovetoStart();
        }

        private void FifthColorWall_MouseEnter(object sender, EventArgs e)
        {
            fifthColorSoundPlayer.Play();
            MovetoStart();
        }

        private void SixthColorWall_MouseEnter(object sender, EventArgs e)
        {
            sixthColorSoundPlayer.Play();
            MovetoStart();
        }

        private void SeventhColorWall_MouseEnter(object sender, EventArgs e)
        {
            seventhColorSoundPlayer.Play();
            MovetoStart();
        }

        private void EighthColorWall_MouseEnter(object sender, EventArgs e)
        {
            eighthColorSoundPlayer.Play();
            MovetoStart();
        }

        private void NinethColorWall_MouseEnter(object sender, EventArgs e)
        {
            ninthColorSoundPlayer.Play();
            MovetoStart();
        }

        private void TenthColorWall_MouseEnter(object sender, EventArgs e)
        {
            tenthColorSoundPlayer.Play();
            MovetoStart();
        }

    }
}
