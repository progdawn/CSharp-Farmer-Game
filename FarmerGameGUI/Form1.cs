//Dawn Myers
//ITDEV 115
//Farmer Game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGameGUI
{
    public partial class foxChickenGrain : Form
    {
        FarmerGame theGame;

        public foxChickenGrain()
        {
            InitializeComponent();
            ResetLocations();
            Play();
        }

        public void Play()
        {
            theGame = new FarmerGame();
            if(theGame.AnimalAteFood() == true)
            {
                MessageBox.Show("GAME OVER!");
            }


        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetLocations();
            Play();
        }

        private void chicken_Click(object sender, EventArgs e)
        {
            MoveChicken();
            ProcessChoice("CHICKEN");
        }

        public void farmer_Click(object sender, EventArgs e)
        {
            MoveFarmer();
            ProcessChoice("");
        }

        public void fox_Click(object sender, EventArgs e)
        {
            MoveFox();
            ProcessChoice("FOX");
        }

        public void grain_Click(object sender, EventArgs e)
        {
            MoveGrain();
            ProcessChoice("GRAIN");
        }

        public void ResetLocations()
        {
            chicken.Location = new Point(237, 53);
            grain.Location = new Point(493, 35);
            farmer.Location = new Point(119, 27);
            fox.Location = new Point(361, 60);
        }

        public void MoveChicken()
        {
            if (chicken.Location == new Point(237, 53))
            {
                chicken.Location = new Point(237, 429);
            }
            else
            {
                chicken.Location = new Point(237, 53);
            }

            if (farmer.Location == new Point(119, 27))
            {
                farmer.Location = new Point(119, 425);
            }
            else
            {
                farmer.Location = new Point(119, 27);
            }
        }

        public void MoveGrain()
        {
            if (grain.Location == new Point(493, 35))
            {
                grain.Location = new Point(493, 429);
            }
            else
            {
                grain.Location = new Point(493, 35);
            }

            if (farmer.Location == new Point(119, 27))
            {
                farmer.Location = new Point(119, 425);
            }
            else
            {
                farmer.Location = new Point(119, 27);
            }
        }

        public void MoveFox()
        {
            if (fox.Location == new Point(361, 60))
            {
                fox.Location = new Point(361, 436);
            }
            else
            {
                grain.Location = new Point(361, 60);
            }

            if (farmer.Location == new Point(119, 27))
            {
                farmer.Location = new Point(119, 425);
            }
            else
            {
                farmer.Location = new Point(119, 27);
            }
        }

        public void MoveFarmer()
        {
            if (farmer.Location == new Point(119, 27))
            {
                farmer.Location = new Point(119, 425);
            }
            else
            {
                farmer.Location = new Point(119, 27);
            }
        }

        public void ProcessChoice(string choice)
        {
            theGame.Move(choice);

            if(theGame.AnimalAteFood() == false)
            {
                bool userWon = theGame.DetermineWin();

                if(userWon == true)
                {
                    MessageBox.Show("YOU WON!");
                }
            }
            else
            {
                MessageBox.Show("GAME OVER!");
                ResetLocations();
            }
        }

        private void rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Farmer Game!\n" +
                "As the farmer, you have a chicken, a fox, and a bag of grain.\n" +
                "To win, you must get all three of them to the south bank.\n"+
                "However, keep in mind that chickens love grain!\n"+
                "The fox thinks that chicken is looking might tasty too...\n");
        }

        private void MyInfo_Click(object sender, EventArgs e)
        {
            MyInfo thisInfo = new MyInfo();
            MessageBox.Show(thisInfo.Information());

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
