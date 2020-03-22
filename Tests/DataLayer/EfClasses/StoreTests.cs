using System.Collections.ObjectModel;
using DataLayer.Core;
using DataLayer.EfClasses;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.DataLayer.EfClasses
{
    [TestFixture]
    public class StoreTests
    {
        [Test]
        public void CreateStore()
        {
            var name = "London";
            var compartments = new Collection<IShoppingOrder> { new Mock<IShoppingOrder>().Object };

            var testee = new Store(name, compartments);

            testee.Name.Should().Be(name);
            testee.Compartments.Should().BeEquivalentTo(compartments);
        }
    }
}