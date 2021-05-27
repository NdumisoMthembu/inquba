using inQuba.Drinks.Enums;
using inQuba.Drinks.Models;

namespace inQuba.Drinks
{
    public class Coffee : IDrink
    {
        public byte NumberOfRequiredBeans { get; set; }
        public byte NumberOfRequiredMilk { get; set; }

        public byte SpoonsOfSugar { get; set; }

        public Coffee() 
        {
            this.NumberOfRequiredBeans = 2;
            this.NumberOfRequiredMilk = 0;
        }

        public DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            if(NumberOfRequiredMilk > 0)
            {
                return new DrinkResult
                {
                    DisplayMessage = $"Created white coffee using {spoonsOfSugar} spoons of sugar. The required amount of beans was {this.NumberOfRequiredBeans}",
                    DrinkStatus = DrinkStatus.Success
                };
            }
            return new DrinkResult
            {
                DisplayMessage = $"Created coffee using {spoonsOfSugar} spoons of sugar. The required amount of beans was {this.NumberOfRequiredBeans}",
                DrinkStatus = DrinkStatus.Success
            };
        }

        public MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk)
        {
            return new MilkAndBeanStatus()
            {
                BeanLevel = (int)CoffeeMakeSettings.MaxBeanCapacity - usedBeans,
                MilkLevel = (int)CoffeeMakeSettings.MaxMilkCapacity - usedMilk,
                IsEnoughMilk = ((int)CoffeeMakeSettings.MaxMilkCapacity - usedMilk) >= this.NumberOfRequiredMilk,
                IsEnoughBean = ((int)CoffeeMakeSettings.MaxMilkCapacity - usedMilk) >= this.NumberOfRequiredMilk
            };
        }

    }
}
