using inQuba.Drinks;
using inQuba.Drinks.Enums;
using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.CoffeeMachine.Managers
{
    public class LatteManager : IDrinkManager
    {
      private IDrink Latte { get; set; }
        public LatteManager()
        {
            this.Latte = new Latte();
        }
        public DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            return this.Latte.MakeDrink(spoonsOfSugar);
        }

        public byte GetNumberOfRequiredMilk()
        {
            return this.Latte.NumberOfRequiredMilk;
        }

        public byte GetNumberOfBeansUsed()
        {
            return this.Latte.NumberOfRequiredBeans;
        }

        public MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk)
        {
             return this.Latte.GetMilkAndBeanStatus(usedBeans, usedMilk);
        }
    }
}
