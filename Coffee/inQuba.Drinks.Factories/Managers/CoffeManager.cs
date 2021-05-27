using inQuba.Drinks;
using inQuba.Drinks.Enums;
using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.CoffeeMachine.Managers
{
    public class CoffeManager : IDrinkManager
    {
        private IDrink Coffe { set; get; }
        public CoffeManager()
        {
            this.Coffe = new Coffee();
        }
        public DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            return this.Coffe.MakeDrink(spoonsOfSugar);
        }
        public void SetRequiredMilk(byte numberOfRequiredMilk)
        {
            this.Coffe.NumberOfRequiredMilk = numberOfRequiredMilk;
        }

        public byte GetNumberOfRequiredMilk()
        {
            return this.Coffe.NumberOfRequiredMilk;
        }
        public byte GetNumberOfBeansUsed()
        {
            return this.Coffe.NumberOfRequiredBeans;
        }

        public MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk)
        {
            return this.Coffe.GetMilkAndBeanStatus(usedBeans, usedMilk);
        }
    }
}
