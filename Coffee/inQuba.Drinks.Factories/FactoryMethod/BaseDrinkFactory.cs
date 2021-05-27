using inQuba.CoffeeMachine.Managers;
using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.Drinks.Factories.FactoryMethod
{
   public abstract class BaseDrinkFactory
    {
        public byte TotalBeansUsed { get; set; }
        public byte TotalMilkUsed { get; set; }
        public BaseDrinkFactory()
        {

        }
        public abstract IDrinkManager Create();

        public abstract DrinkResult MakeDrink(byte spoonsOfSugar);
        public abstract MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk);
        public abstract void SetRequiredMilk(byte milk);
        public abstract byte GetNumberOfBeansUsed();
        public abstract byte GetNumberOfRequiredMilk();

        public void UpdateBeansUsed(byte beans) {
            this.TotalBeansUsed += beans;
        }   
        public void UpdateMilkUsed(byte milk) {
            this.TotalMilkUsed += milk;
        }
        
    }
}
