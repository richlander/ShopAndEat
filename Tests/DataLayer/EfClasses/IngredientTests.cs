using System.Diagnostics.CodeAnalysis;
using DataLayer.Core;
using DataLayer.EfClasses;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.DataLayer.EfClasses
{
    [TestFixture]
    public class IngredientTests
    {
        [Test]
        [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
        public void CreateIngredient()
        {
            var name = "Salat";
            var ingredientGroup = new IngredientGroup("Gemüse");
            var unit = Unit.Liter;
            var isInventory = true;

            var testee = new Ingredient(name, ingredientGroup, unit, isInventory);

            testee.Name.Should().Be(name);
            testee.IngredientGroup.Should().Be(ingredientGroup);
            testee.Unit.Should().Be(unit);
            testee.IsInventory.Should().Be(isInventory);
        }
    }
}