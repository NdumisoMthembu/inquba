using inQuba.Drinks.Enums;
using inQuba.Drinks.Models;

namespace inQuba.Drinks
{
    public class Latte : IDrink
    {
        public byte NumberOfRequiredBeans { get; set; }
        public byte NumberOfRequiredMilk { get; set; }

        public Latte()
        {
            this.NumberOfRequiredBeans = 1;
            this.NumberOfRequiredMilk = 2;
        }

        public DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            return new DrinkResult
            {
                DisplayMessage = $"Created a latte using {spoonsOfSugar} spoons of sugar. The required amount of beans was {this.NumberOfRequiredBeans}",
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
