using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cat_Race_Assignment
{
    public partial class Form1 : Form
    {
        
        //objects of the classes
        Greyhound[] cats = new Greyhound[4];//instance of greyhound class
        Guy[] guys = new Guy[3];//it is the object of guy class
        public Form1()
        {
            InitializeComponent();
           RaceTrackSetting();
        
       
    }

    private void Placebet_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;

           if (radioButtonjoe.Checked)
           {
                GuyNumber = 0;// set joe's id as 0 on radio button click
            }
           if (radioButtonBob.Checked)
            {
                GuyNumber = 1;//set bob's id as 1 on radio button click
           }
           if (radioButtonAl.Checked)
           {
                GuyNumber = 2;//set Al's id as 2 on radio button click
            }

            guys[GuyNumber].PlaceBet((int)numericUpDownbet.Value, (int)numericUpDowncat.Value); // code to set bet and show the amount on raddio button click 
            guys[GuyNumber].UpdateLabels(); //code to update  the labels 
        }

        private void Race_Click(object sender, EventArgs e)
        {
            CarRacingStart();
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        
            private void RaceTrackSetting()
            { 
            Minimunbet.Text = string.Format("Minimum Bet $1", (int)numericUpDownbet.Minimum);//Showing the minimum bet rate in label

            int startingPosition = cat1.Right - Raceground.Left; //code to set the variable for starting position from car 1
            int raceTrackLength = Raceground.Size.Width;//code to set the variable of racetrack's length

            //code to set the values of the array of the class greyhound for cat race
            cats[0] = new Greyhound()
            {
                MyPictureBox = cat1,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            cats[1] = new Greyhound()
            {
                MyPictureBox = cat2,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            cats[2] = new Greyhound()
            {
                MyPictureBox = cat3,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            cats[3] = new Greyhound()
            {
                MyPictureBox = cat4,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };

            //code is to assign the constructor values  created in guy class
            guys[0] = new Guy("Joe", null, 50, radioButtonjoe, label3);
            guys[1] = new Guy("Bob", null, 50, radioButtonBob, label4);
            guys[2] = new Guy("Al", null, 50, radioButtonAl, label5);

            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();// foreach loop to assign the values of labels for bet
            }
        }

        private void CarRacingStart()
        {
            bool NoWinner = true;
            int winnercat;
            

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < cats.Length; i++)//code to start the race and finish it till the end line of track 
                {
                    Thread.Sleep(1);//sleep function for the speed of cats
                    if (cats[i].Run())//here run function is called from greyhound class for running the cats and condition is checked 
                    {
                        winnercat = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - cat #" + winnercat);
                        foreach (Guy guy in guys)
                        {
                            if (guy.MyBet != null)//condition is checked for betting
                            {
                                guy.Collect(winnercat);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }

                        foreach (Greyhound cat in cats)
                        {
                            cat.TakeStartingPosition();
                        }

                        break;
                    }
                }

            }
        }
          
        private void Endgame_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
    }



        


