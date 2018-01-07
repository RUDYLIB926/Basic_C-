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
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = $"{Name} has ${Cash} to bet.";
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
            MyBet.Bettor = this;
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if(Cash >= BetAmount)
            {
                MyBet.Amount = BetAmount;
                MyBet.Bettor = this;
                MyBet.Dog = DogToWin;
                return true;
            }
            else
            {
                MessageBox.Show("Not enough cash available to make that bet.");
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }
    }
}
