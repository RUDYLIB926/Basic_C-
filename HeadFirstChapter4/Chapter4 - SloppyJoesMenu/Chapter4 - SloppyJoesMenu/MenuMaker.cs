using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4___SloppyJoesMenu
{
    class MenuMaker
    {
        public Random Randomizer = new Random();

        string[] Meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = {"yellow mustard", "brown mustard",
                    "honey mustard", "mayo", "relish", "french dressing"};
        string[] Breads = {"rye", "white", "whole wheat", "pumpernickel",
                    "multigrain", "a roll"};


        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return $"{randomMeat} with {randomCondiment} on {randomBread}";
        }
    }
}