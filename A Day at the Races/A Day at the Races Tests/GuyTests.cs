using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_Day_at_the_Races;

namespace A_Day_at_the_Races_Tests
{
    [TestClass]
    public class GuyTests
    {
        [TestMethod]
        public void newGuyTest()
        {
            Guy guy = new Guy() { Name = "guy", Cash = 0, MyBet = null};

            Assert.IsNotNull(guy);
        }
    }
}
