using inQuba.CoffeeMachine.Managers;
using System;

namespace inQuba.Drinks.Factories
{
    public class DrinkFactory : IDrinkFactory
    {
        public IDrink Create(string drink)
        {
            throw new NotImplementedException();
        }

        //public IDrink Create(string drink)
        //{
        //    switch (drink)
        //    {
        //        case "Coffee":
        //            return new Coffee();
        //        case "Latte":
        //            return new Latte();
        //        case "Cappuccino":
        //            return new Cappuccino();
        //        default:
        //            throw new Exception("Unknown Drink");
        //    }
        //}

        public IDrinkManager GetDrinkManager(string drink)
        {
            switch (drink)
            {
                case "Coffee":
                    return new CoffeManager();
                case "Latte":
                    return new LatteManager();
                case "Cappuccino":
                    return new CappuccinoManager();
                default:
                    throw new Exception("Unknown Drink");
            }

        } 
    }
}
