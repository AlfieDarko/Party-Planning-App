using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DinnerParty
    {


        public const int CostOfFoodPerPerson = 25;


        public decimal CostOfDecorations { get; set; }

        public decimal CostOfBeveragesPerPerson { get; set; }

        // These properties are set in the constructor and updated by the 
        // form and theyre used when calculating the cost

        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        private int numberOfPeople;
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }

            set
            {
                numberOfPeople = value;
            }
        }

        public DinnerParty (int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
        // Here's the DinnerParty constructor. It sets the three properties based on
        // the values passed into it by the form


        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (numberOfPeople * 15.00M) + 50.00M;
                return costOfDecorations;
            }
            else
            {
                costOfDecorations = (numberOfPeople * 7.50M) + 30.00M;
                return costOfDecorations;
            }
        }

        // By making this method private you made sure that it can't be accessed from outside
        // of the class, which will keep it from being misused

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
                return costOfBeveragesPerPerson;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
                return costOfBeveragesPerPerson;
            }
        }
        // The private methods used in the cost calculation access the properties
        // so that they have the latest information from the form

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson()
                    + CostOfFoodPerPerson) * NumberOfPeople);

                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }

        // Now that the calculations are private and encapsulated behind the Cost property,
        // theres no way for the form to recalculate the cost of the decorations that
        // doesnt use the current options. That'll fix the bug that almost acost Kathleen one
        // of her best clients!
    }
}
