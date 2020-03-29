using DataLayer.EfClasses;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UnitTests.DataLayer.EfClasses
{
    [TestFixture]
    public class IngredientTests
    {
        [Test]
        public void CreateIngredient()
        {
            var article = new Article("Tomato", new ArticleGroup("Vegetables"), false);
            uint quantity = 3;
            var unit = new Unit("Bag");

            var testee = new Ingredient(article, quantity, unit);

            testee.Article.Should().Be(article);
            testee.Quantity.Should().Be(quantity);
            testee.Unit.Should().Be(unit);
        }
    }
}