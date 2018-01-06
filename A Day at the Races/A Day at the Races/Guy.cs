using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabel()
        {

        }

        public void ClearBet()
        {

        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            return true;
        }

        public void Collect(int Winner)
        {

        }
    }
}
