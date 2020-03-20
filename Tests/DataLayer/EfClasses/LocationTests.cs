using DataLayer.EfClasses;
using FluentAssertions;
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

            var testee = new Location(name);

            testee.Name.Should().Be(name);
        }
    }
}