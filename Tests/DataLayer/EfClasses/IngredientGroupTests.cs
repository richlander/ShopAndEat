using DataLayer.EfClasses;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.DataLayer.EfClasses
{
    [TestFixture]
    public class IngredientGroupTests
    {
        [Test]
        public void CreateIngredientGroup()
        {
            var name = "Gemüse";

            var testee = new IngredientGroup(name);

            testee.Name.Should().Be(name);
        }
    }
}