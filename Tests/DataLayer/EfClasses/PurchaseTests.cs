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
    public class PurchaseTests
    {
        [Test]
        public void CreatePurchase()
        {
            var from = new DateTime();
            var to = new DateTime();
            var purchaseItems = new Collection<IPurchaseItem> { new Mock<IPurchaseItem>().Object };

            var testee = new Purchase(from, to, purchaseItems);

            testee.From.Should().Be(from);
            testee.To.Should().Be(to);
            testee.PurchaseItems.Should().BeEquivalentTo(purchaseItems);
        }
    }
}