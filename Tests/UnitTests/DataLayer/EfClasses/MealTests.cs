using System;
using DataLayer.EfClasses;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UnitTests.DataLayer.EfClasses
{
    [TestFixture]
    public class MealTests
    {
        [Test]
        public void CreateMeal()
        {
            var day = new DateTime();
            var mealType = new MealType("Lunch");
            var recipe = new Recipe("Soup", 3, new Ingredient[] { });

            var testee = new Meal(day, mealType, recipe);

            testee.Day.Should().Be(day);
            testee.MealType.Should().Be(mealType);
            testee.Recipe.Should().Be(recipe);
        }
    }
}