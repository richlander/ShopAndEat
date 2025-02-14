﻿using System;
using DataLayer.EfClasses;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UnitTests.DataLayer.EfClasses;

[TestFixture]
public class MealTests
{
    [Test]
    public void CreateMeal()
    {
        var day = new DateTime();
        var mealType = new MealType("Lunch", 1);
        var recipe = new Recipe("Soup", 3, 2, new Ingredient[] { });

        var testee = new Meal(day, mealType, recipe, 2);

        testee.Day.Should().Be(day);
        testee.MealType.Should().Be(mealType);
        testee.Recipe.Should().Be(recipe);
        testee.NumberOfPersons.Should().Be(2);
    }
}