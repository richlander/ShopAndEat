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
            var ingredients = new Collection<IIngredient> { new Mock<IIngredient>().Object };

            var testee = new Recipe(name, numberOfDays, ingredients);

            testee.Name.Should().Be(name);
            testee.NumberOfDays.Should().Be(numberOfDays);
            testee.Ingredients.Should().BeEquivalentTo(ingredients);
        }

        [Test]
        public void AddIngredient()
        {
            var name = "Suppe";
            var numberOfDays = 3;
            var ingredients = new Collection<IIngredient> { new Mock<IIngredient>().Object };
            var testee = new Recipe(name, numberOfDays, ingredients);
            var ingredientToAdd = new Mock<IIngredient>().Object;

            testee.AddIngredient(ingredientToAdd);

            testee.Ingredients.Should().Contain(ingredientToAdd);
        }

        [Test]
        public void DeleteComponent()
        {
            var name = "Suppe";
            var numberOfDays = 3;
            var ingredient = new Mock<IIngredient>().Object;
            var ingredients = new Collection<IIngredient> { ingredient };
            var testee = new Recipe(name, numberOfDays, ingredients);

            testee.DeleteIngredient(ingredient);

            testee.Ingredients.Should().NotContain(ingredient);
        }
    }
}