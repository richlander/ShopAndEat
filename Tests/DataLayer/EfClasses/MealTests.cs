using System;
using DataLayer.Core;
using DataLayer.EfClasses;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.DataLayer.EfClasses
{
    [TestFixture]
    public class MealTests
    {
        [Test]
        public void CreateMeal()
        {
            var day = new DateTime();
            var mealType = new Mock<IMealType>().Object;
            var recipe = new Mock<IRecipe>().Object;

            var testee = new Meal(day, mealType, recipe);

            testee.Day.Should().Be(day);
            testee.MealType.Should().Be(mealType);
            testee.Recipe.Should().Be(recipe);
        }
    }
}