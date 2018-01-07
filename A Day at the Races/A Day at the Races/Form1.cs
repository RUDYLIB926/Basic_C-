using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public partial class Form1 : Form
    {
        private Random MyRandom = new Random();
        private Greyhound[] dogs;
        private Guy[] boys;

        public Form1()
        {
            InitializeComponent();
            InitializeDogs();
            InitializeGuys();
            minimumBetLabel.Text = "Minimum Bet: $" + selectAmount.Minimum.ToString();
        }

        private void InitializeGuys()
        {
            boys = new Guy[3];
            for (int i = 0; i < boys.Length; i++)
            {
                boys[i] = new Guy();
                switch (i)
                {
                    case 0:
                        boys[i].Name = "Joe";
                        boys[i].MyRadioButton = joeRadioButton;
                        boys[i].MyLabel = joesBetLabel;
                        boys[i].Cash = 50;
                        boys[i].MyBet = null;
                        break;
                    case 1:
                        boys[i].Name = "Bob";
                        boys[i].MyRadioButton = bobRadioButton;
                        boys[i].MyLabel = bobsBetLabel;
                        boys[i].Cash = 75;
                        boys[i].MyBet = null;
                        break;
                    case 2:
                        boys[i].Name = "Al";
                        boys[i].MyRadioButton = alRadioButton;
                        boys[i].MyLabel = alsBetLabel;
                        boys[i].Cash = 45;
                        boys[i].MyBet = null;
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < boys.Length; i++)
            {
                boys[i].MyBet = new Bet();
                boys[i].ClearBet();
                boys[i].UpdateLabel();
            }
        }

        private void InitializeDogs()
        {
            dogs = new Greyhound[4];
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i] = new Greyhound();
                switch (i)
                {
                    case 0:
                        dogs[i].MyPictureBox = dog1;
                        dogs[i].StartingPosition = dog1.Left;
                        dogs[i].RacetrackLength = pictureBox.Width - dog1.Width;
                        dogs[i].Randomizer = MyRandom;
                        break;
                    case 1:
                        dogs[i].MyPictureBox = dog2;
                        dogs[i].StartingPosition = dog2.Left;
                        dogs[i].RacetrackLength = pictureBox.Width - dog2.Width;
                        dogs[i].Randomizer = MyRandom;
                        break;
                    case 2:
                        dogs[i].MyPictureBox = dog3;
                        dogs[i].StartingPosition = dog3.Left;
                        dogs[i].RacetrackLength = pictureBox.Width - dog3.Width;
                        dogs[i].Randomizer = MyRandom;
                        break;
                    case 3:
                        dogs[i].MyPictureBox = dog4;
                        dogs[i].StartingPosition = dog4.Left;
                        dogs[i].RacetrackLength = pictureBox.Width - dog4.Width;
                        dogs[i].Randomizer = MyRandom;
                        break;
                    default:
                        break;
                }
            }
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (boys[i].MyRadioButton.Checked)                
                    if(boys[i].PlaceBet((int)selectAmount.Value, (int)selectDog.Value))
                        boys[i].UpdateLabel();             
            }
        }

        private void startRaceButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].TakeStartingPosition();
            }
            groupBox.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i].Run())
                {
                    timer1.Stop();
                    groupBox.Enabled = true;
                    i++;
                    MessageBox.Show($"Dog #{i} won the race!", "We have a winner");
                    for (int j = 0; j <= 2; j++)
                    {
                        boys[j].Collect(i);
                        boys[j].ClearBet();
                        boys[j].UpdateLabel();
                    }
                    break;
                }
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }
    }
}
