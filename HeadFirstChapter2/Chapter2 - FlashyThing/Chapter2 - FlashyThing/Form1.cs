using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2___FlashyThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int C = 0; C < 253 && Visible; C++)
                {
                    this.BackColor = Color.FromArgb(C, 255 - C, C);

                    Application.DoEvents();

                    System.Threading.Thread.Sleep(3);
                }

                for (int C = 254 - 1; C >= 0 && Visible; C--)
                {
                    this.BackColor = Color.FromArgb(C, 255 - C, C);

                    Application.DoEvents();

                    System.Threading.Thread.Sleep(3);
                }
            }            
        }
    }
}
