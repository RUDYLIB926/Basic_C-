﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4___Elephants
{
    class Elephant
    {
        public string Name { get; set; }
        public int EarSize { get; set; }

        public void WhoAmI()
        {
            MessageBox.Show($"My ears are {EarSize} inches tall.", $"{Name} says...");
        }
    }
}
