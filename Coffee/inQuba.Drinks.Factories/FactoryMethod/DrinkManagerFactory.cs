using System;
using System.Collections.Generic;
using System.Text;

namespace inQuba.Drinks.Factories.FactoryMethod
{
   public class DrinkManagerFactory
    {
        public BaseDrinkFactory CreateFactory(string drink)
        {
            BaseDrinkFactory baseDrinkFactory = null;
            switch (drink)
            {

                case "Coffee":
                case "1":
                    return new CoffeeFactory();

                case "Latte":
                case "2":
                    return new LatteFactory();

                case "Cappuccino":
                case "3":
                    return new CappuccinoFactory();

                default:
                    return baseDrinkFactory;
            }
        }
    }
}
