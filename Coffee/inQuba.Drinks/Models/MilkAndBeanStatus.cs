using inQuba.Drinks.Enums;

namespace inQuba.Drinks.Models
{
    public class MilkAndBeanStatus
    {
        public int MilkLevel { get; set; }

        public int BeanLevel { get; set; }

        public bool IsEnoughMilk { get; set; }
        public bool IsEnoughBean { get; set; }

    }
}
