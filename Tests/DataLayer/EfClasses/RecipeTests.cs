using System.Collections.ObjectModel;
using DataLayer.Core;
using DataLayer.EfClasses;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.DataLayer.EfClasses
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void CreateRezept()
        {
            var name = "Suppe";
            var numberOfDays = 3;
            var ingredients = new Collection<(IIngredient, int)> { (new Mock<IIngredient>().Object, 3) };

            var testee = new Recipe(name, numberOfDays, ingredients);

            testee.Name.Should().Be(name);
            testee.NumberOfDays.Should().Be(numberOfDays);
            testee.Ingredients.Should().BeEquivalentTo(ingredients);
        }
    }
}