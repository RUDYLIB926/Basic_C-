using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        int NumberOfPeople;
        decimal CostOfBeveragesPerPerson;
        decimal CostOfDecorations;

        public void SetPartyOptions(int people, bool fancyOption)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancyOption);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        public void SetHealthyOptions(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }
         
        public void CalculateCostOfDecorations(bool fancyOption)
        {
            if (fancyOption)
                CostOfDecorations = ((15.00M * NumberOfPeople) + 50.00M);
            else
                CostOfDecorations = ((7.50M * NumberOfPeople) + 30.00M);
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost= CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            decimal discount;
            if (healthyOption)
                discount = totalCost * .05M;
            else
                discount = 0.0M;
            return totalCost - discount;
        }
    }
}
