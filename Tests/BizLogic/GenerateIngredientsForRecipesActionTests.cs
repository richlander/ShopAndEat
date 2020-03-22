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
    public class GenerateIngredientsForRecipesActionTests
    {
        [Test]
        public void GenerateComponents()
        {
            var tomato = new Mock<IArticle>().Object;
            var salad = new Mock<IArticle>().Object;
            var bag = new Mock<IUnit>().Object;
            var piece = new Mock<IUnit>().Object;
            var ingredientMock1 = new Mock<IIngredient>();
            ingredientMock1.Setup(x => x.Article).Returns(tomato);
            ingredientMock1.Setup(x => x.Quantity).Returns(2);
            ingredientMock1.Setup(x => x.Unit).Returns(bag);
            var ingredientMock2 = new Mock<IIngredient>();
            ingredientMock2.Setup(x => x.Article).Returns(salad);
            ingredientMock2.Setup(x => x.Quantity).Returns(3);
            ingredientMock2.Setup(x => x.Unit).Returns(bag);
            var ingredientMock3 = new Mock<IIngredient>();
            ingredientMock3.Setup(x => x.Article).Returns(tomato);
            ingredientMock3.Setup(x => x.Quantity).Returns(1);
            ingredientMock3.Setup(x => x.Unit).Returns(piece);
            var ingredientMock4 = new Mock<IIngredient>();
            ingredientMock4.Setup(x => x.Article).Returns(salad);
            ingredientMock4.Setup(x => x.Quantity).Returns(5);
            ingredientMock4.Setup(x => x.Unit).Returns(bag);
            var recipeMock1 = new Mock<IRecipe>();
            recipeMock1.Setup(x => x.Ingredients)
                       .Returns(new ReadOnlyCollection<IIngredient>(new List<IIngredient>
                                                                    {
                                                                        ingredientMock1.Object, ingredientMock2.Object
                                                                    }));
            var recipeMock2 = new Mock<IRecipe>();
            recipeMock2.Setup(x => x.Ingredients)
                       .Returns(new ReadOnlyCollection<IIngredient>(new List<IIngredient>
                                                                    {
                                                                        ingredientMock3.Object, ingredientMock4.Object
                                                                    }));
            var recipe1 = recipeMock1.Object;
            var recipe2 = recipeMock2.Object;
            var recipes = new Collection<IRecipe> { recipe1, recipe2 };
            var testee = new GeneratePurchaseItemsForRecipesAction();

            var results = testee.GeneratePurchaseItems(recipes).ToList();

            results.Should().HaveCount(3);
            results.Should().Contain(x => x.Article == tomato && x.Quantity == 2 && x.Unit == bag);
            results.Should().Contain(x => x.Article == tomato && x.Quantity == 1 && x.Unit == piece);
            results.Should().Contain(x => x.Article == salad && x.Quantity == 8 && x.Unit == bag);
        }
    }
}