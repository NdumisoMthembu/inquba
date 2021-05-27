using inQuba.Drinks.Models;

namespace inQuba.Drinks
{
    public interface IDrink
    {
        byte NumberOfRequiredBeans { get; set; }
        byte NumberOfRequiredMilk { get; set; }

        DrinkResult MakeDrink(byte spoonsOfSugar);
        MilkAndBeanStatus GetMilkAndBeanStatus(byte usedBeans, byte usedMilk);
    }
}
