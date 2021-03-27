using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Race_Assignment
{
    class Bet 
    {
        // variables declaration
        public int Amount;

        public int Cat { get; }

        public int cat;
        public Guy Bettor;

        public Bet(int Amount, int Bike, Guy Bettor)//this is constructor
        {
            this.Amount = Amount;
            this.Cat = Cat;
            this.Bettor = Bettor;
        }

        public string GetDescription()//code is to set the discription of labels once bet is placed and also its amount is changed 
        {
            string description = "";

            if (Amount > 1)
            {
                description = String.Format("{0} bets ${1} on cat #{2}", Bettor.Name, Amount, cat);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets", Bettor.Name);
            }


            return description;
        }

        public int PayOut(int Winner)//code for payout for that cat who win the race
        {

           if (cat == Winner)
           {

                 return Amount;

            }
                  return -Amount;
        }
    }
}

    

