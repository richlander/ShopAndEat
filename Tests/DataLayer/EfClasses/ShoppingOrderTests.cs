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
            var ingredientGroup = new Mock<IArticleGroup>().Object;
            var store = new Mock<IStore>().Object;

            var testee = new ShoppingOrder(store, ingredientGroup, order);

            testee.Store.Should().Be(store);
            testee.ArticleGroup.Should().Be(ingredientGroup);
            testee.Order.Should().Be(order);
        }
    }
}