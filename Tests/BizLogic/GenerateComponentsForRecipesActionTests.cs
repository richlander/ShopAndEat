using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BizLogic.Concrete;
using DataLayer.Core;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.BizLogic
{
    [TestFixture]
    public class GenerateComponentsForRecipesActionTests
    {
        [Test]
        public void GenerateComponents()
        {
            var tomato = new Mock<IIngredient>().Object;
            var salad = new Mock<IIngredient>().Object;
            var recipeMock1 = new Mock<IRecipe>();
            recipeMock1.Setup(x => x.Components)
                       .Returns(new ReadOnlyCollection<(IIngredient, int)>(new List<(IIngredient, int)> { (tomato, 2), (salad, 3) }));
            var recipeMock2 = new Mock<IRecipe>();
            recipeMock2.Setup(x => x.Components)
                       .Returns(new ReadOnlyCollection<(IIngredient, int)>(new List<(IIngredient, int)> { (tomato, 1), (salad, 1) }));
            var recipe1 = recipeMock1.Object;
            var recipe2 = recipeMock2.Object;
            var recipes = new Collection<IRecipe> { recipe1, recipe2 };
            var testee = new GenerateComponentsForRecipesAction();

            var results = testee.GenerateComponents(recipes).ToList();

            results.Should().BeEquivalentTo((tomato, 3), (salad, 4));
        }
    }
}