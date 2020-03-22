using System.Linq;
using BizLogic.Concrete;
using DataLayer.Core;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.BizLogic
{
    [TestFixture]
    public class OrderPurchaseItemsByStoreActionTests
    {
        [Test]
        public void OrderPurchaseItemsByStore()
        {
            var vegetablesMock = new Mock<IArticleGroup>();
            var dairyMock = new Mock<IArticleGroup>();
            var tomatoMock = new Mock<IArticle>();
            tomatoMock.Setup(x => x.ArticleGroup).Returns(vegetablesMock.Object);
            var tomato = tomatoMock.Object;
            var milkMock = new Mock<IArticle>();
            milkMock.Setup(x => x.ArticleGroup).Returns(dairyMock.Object);
            var milk = milkMock.Object;
            var purchaseItemMock1 = new Mock<IPurchaseItem>();
            purchaseItemMock1.Setup(x => x.Article).Returns(tomato);
            purchaseItemMock1.Setup(x => x.Quantity).Returns(2);
            var purchaseItemMock2 = new Mock<IPurchaseItem>();
            purchaseItemMock2.Setup(x => x.Article).Returns(milk);
            purchaseItemMock2.Setup(x => x.Quantity).Returns(3);
            var shoppingOrderMock1 = new Mock<IShoppingOrder>();
            shoppingOrderMock1.Setup(x => x.ArticleGroup).Returns(vegetablesMock.Object);
            shoppingOrderMock1.Setup(x => x.Order).Returns(50);
            var shoppingOrderMock2 = new Mock<IShoppingOrder>();
            shoppingOrderMock2.Setup(x => x.ArticleGroup).Returns(dairyMock.Object);
            shoppingOrderMock2.Setup(x => x.Order).Returns(30);
            var compartments = new[] { shoppingOrderMock1.Object, shoppingOrderMock2.Object };
            var storeMock = new Mock<IStore>();
            storeMock.Setup(x => x.Compartments).Returns(compartments);
            var purchaseItems = new[] { purchaseItemMock1.Object, purchaseItemMock2.Object };
            var testee = new OrderPurchaseItemsByStoreAction();

            var results = testee.OrderPurchaseItemsByStore(storeMock.Object, purchaseItems).ToList();

            results.Should().HaveCount(2);
            results.Should().BeEquivalentTo(purchaseItemMock2.Object, purchaseItemMock1.Object);
        }
    }
}