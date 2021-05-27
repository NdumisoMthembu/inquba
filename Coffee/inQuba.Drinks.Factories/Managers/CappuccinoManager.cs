using inQuba.Drinks;
using inQuba.Drinks.Enums;
using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.CoffeeMachine.Managers
{
    public class CappuccinoManager : IDrinkManager
    {
        private IDrink Cappuccino { get; set; }
        public CappuccinoManager()
        {
            this.Cappuccino = new Cappuccino();
        }
     

        public DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            return this.Cappuccino.MakeDrink(spoonsOfSugar);
        }

        public byte GetNumberOfRequiredMilk()
        {
            return this.Cappuccino.NumberOfRequiredMilk;
        }
        
        public byte GetNumberOfBeansUsed()
        {
            return this.Cappuccino.NumberOfRequiredBeans;
        }

        public MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk)
        {
            return this.Cappuccino.GetMilkAndBeanStatus(usedBeans,usedMilk);
        }
    }
}
