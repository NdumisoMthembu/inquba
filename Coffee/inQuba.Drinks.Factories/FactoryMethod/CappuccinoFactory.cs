using inQuba.CoffeeMachine.Managers;
using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.Drinks.Factories.FactoryMethod
{
public    class CappuccinoFactory : BaseDrinkFactory
    {
        CappuccinoManager CappuccinoManager { set; get; }
        public CappuccinoFactory() : base()
        {
            this.CappuccinoManager = new CappuccinoManager();
        }
        public override IDrinkManager Create()
        {
   
            CappuccinoManager cappuccinoManager = new CappuccinoManager();

            return cappuccinoManager;
        }

        public override DrinkResult MakeDrink(byte spoonsOfSugar)
        {
            base.UpdateBeansUsed(this.GetNumberOfBeansUsed());
            base.UpdateMilkUsed(GetNumberOfRequiredMilk());
            return this.CappuccinoManager.MakeDrink(spoonsOfSugar);
        }

        public override byte GetNumberOfRequiredMilk()
        {
            return this.CappuccinoManager.GetNumberOfRequiredMilk();
        }

        public override byte GetNumberOfBeansUsed()
        {
            return this.CappuccinoManager.GetNumberOfBeansUsed();
        }

        public override void SetRequiredMilk(byte milk)
        {
            throw new NotImplementedException();
        }

        public override MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk)
        {
            return this.CappuccinoManager.GetMilkAndBeanStatus(usedBeans, usedMilk);
        }
    }
}
