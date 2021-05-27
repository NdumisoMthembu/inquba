using System;
using inQuba.CoffeeMachine.Managers;
using inQuba.Drinks.Enums;
using inQuba.Drinks.Factories;
using inQuba.Drinks.Factories.FactoryMethod;

namespace inQuba.CoffeeMachine
{
    public class Program
    {
        static byte totalBeansUsed = 0;
        static byte totalMilkUsed = 0;

        static BaseDrinkFactory GetBaseDrinkFactory()
        {
            Console.WriteLine("What Drink you would like to drink?");
            Console.WriteLine(String.Format("1. Coffee {0}2. Latte {1}3. Cappuccino", Environment.NewLine, Environment.NewLine));

            string command = Console.ReadLine();

            CheckForCloseCmd(command);
            var  drinkFactory =  new DrinkManagerFactory().CreateFactory(command);
            if (drinkFactory == null) {
                Console.WriteLine(String.Format("{0}Opps, Invalid selection!{1}", Environment.NewLine, Environment.NewLine));
                return GetBaseDrinkFactory();
                };

            if (drinkFactory.GetNumberOfRequiredMilk() == 0)
            {
                Console.Write("Would you like so me milk? (yes/no)");
                string milkInput = Console.ReadLine();

                while (milkInput.ToLower() != "yes" && milkInput.ToLower() != "no")
                {
                    Console.Write("Opps wrong answer, Would you like so me milk? (Enter yes or no)");
                    milkInput = Console.ReadLine();
                }

                CheckForCloseCmd(milkInput);
                if (milkInput == "yes")
                {
                    drinkFactory.SetRequiredMilk(1);
                }

            }

            Console.WriteLine("Enter the quantity of sugar you require");
            command = Console.ReadLine();
            CheckForCloseCmd(command);

            var beanAndMilkStatus = drinkFactory.GetMilkAndBeanStatus(totalBeansUsed, totalMilkUsed);

            if (!beanAndMilkStatus.IsEnoughBean)
            {
                Console.WriteLine("Opps,no enought beans for this drink");
                return GetBaseDrinkFactory();
            }

            if (beanAndMilkStatus.BeanLevel <= 5)
            {
                Console.WriteLine($"Warning,Beans running low only {beanAndMilkStatus.BeanLevel} remaining");
            }


            if (!beanAndMilkStatus.IsEnoughMilk)
            {
                Console.WriteLine("Opps,no enough milk for this drink");
                return GetBaseDrinkFactory();
            }
            var result = drinkFactory.MakeDrink(Convert.ToByte(command));
            totalBeansUsed += drinkFactory.TotalBeansUsed;
            totalMilkUsed += drinkFactory.TotalMilkUsed;
            Console.WriteLine(result.DisplayMessage);
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("{0}Ready to order another drink?{1}", Environment.NewLine, Environment.NewLine));
            return GetBaseDrinkFactory();
        }

        static void CheckForCloseCmd(string commmand)
        {
            if (commmand.ToLower() == "off")
            {
                Environment.Exit(1);
            }
        }

        public static void Main(string[] args)
        {

            BaseDrinkFactory _ = GetBaseDrinkFactory();
        }
    }
}
