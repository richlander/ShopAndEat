using DataLayer.Core;
using DataLayer.EfClasses;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.DataLayer.EfClasses
{
    [TestFixture]
    public class ShoppingOrderTests
    {
        [Test]
        public void CreateShoppingOrder()
        {
            var order = 3;
            var ingredientGroup = new Mock<IIngredientGroup>().Object;
            var location = new Mock<ILocation>().Object;

            var testee = new ShoppingOrder(location, ingredientGroup, order);

            testee.Location.Should().Be(location);
            testee.IngredientGroup.Should().Be(ingredientGroup);
            testee.Order.Should().Be(order);
        }
    }
}