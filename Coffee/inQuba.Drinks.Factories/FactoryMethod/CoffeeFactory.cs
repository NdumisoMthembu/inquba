using inQuba.CoffeeMachine.Managers;
using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.Drinks.Factories.FactoryMethod
{
public    class CoffeeFactory : BaseDrinkFactory
    {
        CoffeManager CoffeManager { set; get; }
        public CoffeeFactory() : base()
        {
            this.CoffeManager = new CoffeManager();
        }
        public override IDrinkManager Create()
        {
            CoffeManager coffeManager = new CoffeManager();
            return coffeManager;
        }

        public override DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            base.UpdateBeansUsed(this.GetNumberOfBeansUsed());
            return this.CoffeManager.MakeDrink(spoonsOfSugar);
        }

        public override byte GetNumberOfRequiredMilk()
        {
            return CoffeManager.GetNumberOfRequiredMilk();
        }

        public override void SetRequiredMilk(byte milk)
        {
            base.UpdateMilkUsed(milk);
            this.CoffeManager.SetRequiredMilk(milk);
        }

        public override byte GetNumberOfBeansUsed()
        {
            return CoffeManager.GetNumberOfBeansUsed();
        }

        public override MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk)
        {
            return this.CoffeManager.GetMilkAndBeanStatus(usedBeans, usedMilk);
        }
    }
}
