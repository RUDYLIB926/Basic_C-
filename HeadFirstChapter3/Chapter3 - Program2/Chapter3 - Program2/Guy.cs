using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3___Program2
{
    class Guy
    {
        public Guy()
        {
            this.Name = " ";
            this.Cash = 0;
        }

        public Guy(string name, int cash)
        {
            this.Name = name;
            this.Cash = cash;
        }
        
        private string _name;
        private int _cash;

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int GiveCash(int amount)
        {
            if(amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show($"I don't have enough cash to give you {amount}, {Name} says...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if(amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show($"{amount} isn't an amount I'll take, {Name} says...");
                return 0;
            }
        }
    }
}
