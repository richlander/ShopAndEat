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
        public void CreateRecipe()
        {
            var name = "Suppe";
            var numberOfDays = 3;
            var components = new Collection<(IIngredient, int)> { (new Mock<IIngredient>().Object, 3) };

            var testee = new Recipe(name, numberOfDays, components);

            testee.Name.Should().Be(name);
            testee.NumberOfDays.Should().Be(numberOfDays);
            testee.Components.Should().BeEquivalentTo(components);
        }

        [Test]
        public void AddComponent()
        {
            var name = "Suppe";
            var numberOfDays = 3;
            var components = new Collection<(IIngredient, int)> { (new Mock<IIngredient>().Object, 3) };
            var testee = new Recipe(name, numberOfDays, components);
            (IIngredient, int) componentToAdd = (new Mock<IIngredient>().Object, 0);

            testee.AddComponent(componentToAdd);

            testee.Components.Should().Contain(componentToAdd);
        }

        [Test]
        public void DeleteComponent()
        {
            var name = "Suppe";
            var numberOfDays = 3;
            var component = (new Mock<IIngredient>().Object, 3);
            var ingredients = new Collection<(IIngredient, int)> { component };
            var testee = new Recipe(name, numberOfDays, ingredients);

            testee.DeleteComponent(component);

            testee.Components.Should().NotContain(component);
        }
    }
}