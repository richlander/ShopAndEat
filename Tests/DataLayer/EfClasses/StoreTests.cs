using System;
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

        [Test]
        public void AddCompartment()
        {
            var name = "London";
            var existingCompartmentMock = new Mock<IShoppingOrder>();
            existingCompartmentMock.Setup(x => x.Order).Returns(30);
            var existingCompartment = existingCompartmentMock.Object;
            var compartments = new Collection<IShoppingOrder> { existingCompartment };
            var compartmentToAddMock = new Mock<IShoppingOrder>();
            compartmentToAddMock.Setup(x => x.Order).Returns(40);
            var compartmentToAdd = compartmentToAddMock.Object;
            var testee = new Store(name, compartments);

            testee.AddCompartment(compartmentToAdd);

            testee.Compartments.Should().BeEquivalentTo(existingCompartment, compartmentToAdd);
        }

        [Test]
        public void AddingCompartmentWithSameOrderThrowsException()
        {
            var name = "London";
            var existingCompartmentMock = new Mock<IShoppingOrder>();
            existingCompartmentMock.Setup(x => x.Order).Returns(30);
            var existingCompartment = existingCompartmentMock.Object;
            var compartments = new Collection<IShoppingOrder> { existingCompartment };
            var compartmentToAddMock = new Mock<IShoppingOrder>();
            compartmentToAddMock.Setup(x => x.Order).Returns(30);
            var compartmentToAdd = compartmentToAddMock.Object;
            var testee = new Store(name, compartments);

            testee.Invoking(x => x.AddCompartment(compartmentToAdd)).Should().Throw<InvalidOperationException>();
        }

        [Test]
        public void DeleteCompartment()
        {
            var name = "London";
            var existingCompartment = new Mock<IShoppingOrder>().Object;
            var compartments = new Collection<IShoppingOrder> { existingCompartment };
            var testee = new Store(name, compartments);

            testee.DeleteCompartment(existingCompartment);

            testee.Compartments.Should().BeEmpty();
        }
    }
}