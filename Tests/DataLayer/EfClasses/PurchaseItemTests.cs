using DataLayer.Core;
using DataLayer.EfClasses;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.DataLayer.EfClasses
{
    [TestFixture]
    public class PurchaseItemTests
    {
        [Test]
        public void CreatePurchaseItem()
        {
            var article = new Mock<IArticle>().Object;
            uint quantity = 3;
            var unit = new Mock<IUnit>().Object;

            var testee = new PurchaseItem(article, quantity, unit);

            testee.Article.Should().Be(article);
            testee.Quantity.Should().Be(quantity);
            testee.Unit.Should().Be(unit);
        }
    }
}