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
            string description = "";
            if (Amount == 0)
                description = $"{Bettor.Name} hasn't placed a bet.";
            else
                description = $"{Bettor.Name} bets ${Amount} on dog #{Dog}";

            return description;
        }

        public int PayOut(int Winner)
        {
            if(Dog == Winner)
            {
                return Amount;
            }else
                return -(Amount);
        }
    }
}
