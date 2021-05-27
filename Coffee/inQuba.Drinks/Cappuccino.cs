using inQuba.Drinks.Enums;
using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.Drinks
{
   public  class Cappuccino : IDrink
    {
        public byte NumberOfRequiredBeans { get; set; }
        public byte NumberOfRequiredMilk { get; set; }
        public Cappuccino()
        {
            this.NumberOfRequiredBeans = 5;
            this.NumberOfRequiredMilk = 3;
        }
        public DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            return new DrinkResult
            {
                DisplayMessage = $"Created cappuccino using {spoonsOfSugar} spoons of sugar. The required amount of beans was {this.NumberOfRequiredBeans}",
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
