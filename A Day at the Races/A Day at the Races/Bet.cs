using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Day_at_the_Races
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            return "";
        }

        public int PayOut(int Winner)
        {
            if(Winner == 4)
            {
                return Amount;
            }else
                return -(Amount);
        }
    }
}
