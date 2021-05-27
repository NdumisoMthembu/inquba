using FluentAssertions;
using NUnit.Framework;

namespace inQuba.Drinks.Tests.Unit
{
    [TestFixture]
    public class CoffeeTests
    {
        [Test]
        public void MakeDrink_ShouldReturnAMessageContainingCoffee_ReturnsMessageContainCoffee()
        {
            IDrink coffee = new Coffee();
            var result = coffee.MakeDrink(2);
            result.DisplayMessage.Should().Contain("coffee");
        }

        [Test]
        public void SetMilk_ShouldReturnAMessageContainingWhiteCoffee_ReturnsMessageWhiteContainCoffee()
        {
            IDrink coffee = new Coffee();
            coffee.NumberOfRequiredMilk = 1;
            var result = coffee.MakeDrink(2);
            result.DisplayMessage.Should().Contain("white coffee");
        }

        [Test]
        public void SetUsedMilkBelowMaxCapacity_ShouldReturnReturnsIsEnoughMilkTrue_ReturnsIsEnoughMilkTrue()
        {
            IDrink coffee = new Coffee();
            var result = coffee.GetMilkAndBeanStatus(2,2);
            Assert.IsTrue(result.IsEnoughMilk);
        }

        [Test]
        public void SetUsedBeanAboveMaxCapacity_ShouldReturnReturnsIsEnoughMilkFalse_ReturnsIsEnougBeansFalse()
        {
            IDrink coffee = new Coffee();
            coffee.NumberOfRequiredMilk = 1;
            var result = coffee.GetMilkAndBeanStatus(50, 50);
            Assert.IsFalse(result.IsEnoughBean);
        }
    }
}