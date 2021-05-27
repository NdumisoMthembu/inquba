using FluentAssertions;
using NUnit.Framework;

namespace inQuba.Drinks.Tests.Unit
{
    [TestFixture]
    public class LatteTests
    {
        [Test]
        public void MakeDrink_ShouldReturnAMessageContainingLatte_ReturnsMessageContainingLatte()
        {
            IDrink coffee = new Latte();
            var result = coffee.MakeDrink(5);
            result.DisplayMessage.Should().Contain("latte");
        }
    }
}
