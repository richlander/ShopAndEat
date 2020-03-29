using System.Collections.ObjectModel;
using DataLayer.EfClasses;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UnitTests.DataLayer.EfClasses
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void CreateRecipe()
        {
            var name = "Suppe";
            var numberOfDays = 3;
            var ingredients = new Collection<Ingredient>
                              {
                                  new Ingredient(new Article("Tomato", new ArticleGroup("Vegetables"), false), 3, new Unit("Bag"))
                              };

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
            var ingredients = new Collection<Ingredient>
                              {
                                  new Ingredient(new Article("Tomato", new ArticleGroup("Vegetables"), false), 3, new Unit("Bag"))
                              };
            var testee = new Recipe(name, numberOfDays, ingredients);
            var ingredientToAdd = new Ingredient(new Article("Salad", new ArticleGroup("Vegetables"), false), 3, new Unit("Bag"));

            testee.AddIngredient(ingredientToAdd);

            testee.Ingredients.Should().Contain(ingredientToAdd);
        }

        [Test]
        public void DeleteComponent()
        {
            var name = "Suppe";
            var numberOfDays = 3;
            var ingredient = new Ingredient(new Article("Tomato", new ArticleGroup("Vegetables"), false), 3, new Unit("Bag"));
            var ingredients = new Collection<Ingredient> { ingredient };
            var testee = new Recipe(name, numberOfDays, ingredients);

            testee.DeleteIngredient(ingredient);

            testee.Ingredients.Should().NotContain(ingredient);
        }
    }
}