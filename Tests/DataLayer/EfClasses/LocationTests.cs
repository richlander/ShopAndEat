using System.Collections.ObjectModel;
using DataLayer.Core;
using DataLayer.EfClasses;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.DataLayer.EfClasses
{
    [TestFixture]
    public class LocationTests
    {
        [Test]
        public void CreateLocation()
        {
            var name = "London";
            var shoppingOrder = new Collection<IShoppingOrder> { new Mock<IShoppingOrder>().Object };

            var testee = new Location(name, shoppingOrder);

            testee.Name.Should().Be(name);
            testee.ShoppingOrder.Should().BeEquivalentTo(shoppingOrder);
        }
    }
}