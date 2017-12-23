using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3___Program2
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;


        public void UpdateForm()
        {
            joesCashLabel.Text = $"{joe.Name} has ${joe.Cash}";
            bobsCashLabel.Text = $"{bob.Name} has ${bob.Cash}";
            bankCashLabel.Text = $"The bank has ${bank}";
        }

        public Form1()
        {
            InitializeComponent();
            joe = new Guy("Joe", 50);
            bob = new Guy("Bob", 100);
        }

        private void giveButton_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }

}