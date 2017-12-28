using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4___Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage = 0;
        int endingMileage = 0;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)setStartingMileage.Value;
            endingMileage = (int)setEndingMileage.Value;

            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                displayAmountOwed.Text = $"${amountOwed}";
            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage.", "Cannot Calculate Mileage.");
            }
        }
    }
}
