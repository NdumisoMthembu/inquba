using inQuba.CoffeeMachine.Managers;
using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.Drinks.Factories.FactoryMethod
{
public    class LatteFactory : BaseDrinkFactory
    {
        LatteManager LatteManager { set; get; }
        public LatteFactory() : base()
        {
            this.LatteManager = new LatteManager();
        }
        public override IDrinkManager Create()
        {

            LatteManager coffeManager = new LatteManager();
            return coffeManager;
        }

        public override DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            base.UpdateBeansUsed(1);
            base.UpdateMilkUsed(2);
            return this.LatteManager.MakeDrink(spoonsOfSugar);
        }

        public override byte GetNumberOfRequiredMilk()
        {
            return LatteManager.GetNumberOfRequiredMilk();
        }

        public override void SetRequiredMilk(byte milk)
        {
            throw new NotImplementedException();
        }

        public override byte GetNumberOfBeansUsed()
        {
            return LatteManager.GetNumberOfBeansUsed();
        }

        public override MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk)
        {
            return this.LatteManager.GetMilkAndBeanStatus(usedBeans, usedMilk);
        }
    }
}
