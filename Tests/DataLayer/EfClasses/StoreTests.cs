using DataLayer.EfClasses;
using FluentAssertions;
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

            var testee = new Store(name);

            testee.Name.Should().Be(name);
        }
    }
}