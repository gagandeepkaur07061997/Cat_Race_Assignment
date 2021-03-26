using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cat_Race_Assignment
{
    class Greyhound
    {
       
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()//Run funtion to make the pictures move 
        {
            MyRandom = new Random();//code to make a random variable
            int distance = MyRandom.Next(1, 10);//code to set the value of distance vaiable

            MoveMyPictureBox(distance);//the movepicturebox funtion is called here

            Location += distance;//code to change the location by increasing the value of distance  
            if (Location >= (RacetrackLength - StartingPosition))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            MoveMyPictureBox(-Location);
            Location = 0;
        }

        public void MoveMyPictureBox(int distance)//code is to move picture boxes 
        {
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
        }
    }
}
    

