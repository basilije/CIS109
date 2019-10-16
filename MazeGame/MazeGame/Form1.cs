/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 3: Create a Maze Game
 * */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        //initialize and define all sounds
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

        //initialize the counter
        int finishCounter = 0;

        //initialize the countdown timer
        int countDownTimer = 30;

        public Form1()
        {
            InitializeComponent();
            SetFormTitle();
            StartTheGame();
        }

        /// <summary>
        /// Function that executed when the game is started
        /// </summary>
        private void StartTheGame()
        {
            startSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that set the Form Title with counter and timer
        /// </summary>
        private void SetFormTitle()
        {
            this.Text = "Maze Game, Finish Counter: " + finishCounter + "   Timer: " + countDownTimer;
        }

        /// <summary>
        /// Function that executes when user enter the "Finish" label
        /// </summary>
        private void LabelFinish_MouseEnter(object sender, EventArgs e)
        {
            finishCounter++;
            SetFormTitle();
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!");            
            //Close();
        }

        /// <summary>
        /// Function to move cursor to the start position
        /// </summary>
        private void MovetoStart()
        {
            countDownTimer = 30;
            SetFormTitle();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the first color
        /// </summary>
        private void FirstColorWall_MouseEnter(object sender, EventArgs e)
        {
            firstColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the second color
        /// </summary>
        private void SecondColorWall_MouseEnter(object sender, EventArgs e)
        {
            secondColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the third color
        /// </summary>
        private void ThirdColorWall_MouseEnter(object sender, EventArgs e)
        {
            thirdColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the fourth color
        /// </summary>
        private void FourthColorWall_MouseEnter(object sender, EventArgs e)
        {
            fourthColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the fifth color
        /// </summary>
        private void FifthColorWall_MouseEnter(object sender, EventArgs e)
        {
            fifthColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the sixth color
        /// </summary>
        private void SixthColorWall_MouseEnter(object sender, EventArgs e)
        {
            sixthColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the seventh color
        /// </summary>
        private void SeventhColorWall_MouseEnter(object sender, EventArgs e)
        {
            seventhColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the eighth color
        /// </summary>
        private void EighthColorWall_MouseEnter(object sender, EventArgs e)
        {
            eighthColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the nineth color
        /// </summary>
        private void NinethColorWall_MouseEnter(object sender, EventArgs e)
        {
            ninthColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes when cursor touch the wall fith the tenth color
        /// </summary>
        private void TenthColorWall_MouseEnter(object sender, EventArgs e)
        {
            tenthColorSoundPlayer.Play();
            MovetoStart();
        }

        /// <summary>
        /// Function that executes every n ticks. Will decrease the counter.
        /// </summary>
        private void DecreaseCountdownTimer(object sender, EventArgs e)
        {
            countDownTimer--;

            // Stop the game and reset the counter;
            if (countDownTimer<1)
            {
                countDownTimer = 30;
                StartTheGame();
            }

            SetFormTitle();
        }
    }
}
