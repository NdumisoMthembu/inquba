using inQuba.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.CoffeeMachine.Managers
{
   public interface IDrinkManager
    {
        DrinkResult MakeDrink(byte spoonsOfSugar);
        //byte GetNumberOfRequiredBeans();
        byte GetNumberOfRequiredMilk();
        byte GetNumberOfBeansUsed();
       abstract MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk);

    }
}
