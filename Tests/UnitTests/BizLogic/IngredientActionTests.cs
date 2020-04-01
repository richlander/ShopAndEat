using BizDbAccess;
using BizLogic.Concrete;
using DataLayer.EfClasses;
using DTO;
using DTO.Article;
using DTO.ArticleGroup;
using DTO.Ingredient;
using DTO.Unit;
using Moq;
using NUnit.Framework;

namespace Tests.UnitTests.BizLogic
{
    [TestFixture]
    public class IngredientActionTests
    {
        [Test]
        public void CreateIngredient()
        {
            var newIngredientDto =
                new NewIngredientDto(new ExistingArticleDto(1, "Tomato", new ExistingArticleGroupDto(1, "Vegetables"), false),
                                     2,
                                     new ExistingUnitDto(1, "Piece"));
            var ingredientDbAccessMock = new Mock<IIngredientDbAccess>();
            var testee = new IngredientAction(ingredientDbAccessMock.Object, new Mapper().CreateMapper());

            testee.CreateIngredient(newIngredientDto);

            ingredientDbAccessMock.Verify(x => x.AddIngredient(It.Is<Ingredient>(a => a.Article.Name == "Tomato")), Times.Once);
        }

        [Test]
        public void DeleteIngredient()
        {
            var deleteIngredientGroupDto = new DeleteIngredientDto(3);
            var ingredientDbAccessMock = new Mock<IIngredientDbAccess>();
            ingredientDbAccessMock.Setup(x => x.GetIngredient(3))
                                  .Returns(new Ingredient(new Article("Tomato", new ArticleGroup("Vegetables"), false),
                                                          2,
                                                          new Unit("Piece")));
            var testee = new IngredientAction(ingredientDbAccessMock.Object, new Mapper().CreateMapper());

            testee.DeleteIngredient(deleteIngredientGroupDto);

            ingredientDbAccessMock.Verify(x => x.DeleteIngredient(It.Is<Ingredient>(a => a.Article.Name == "Tomato")), Times.Once);
        }

        [Test]
        public void GetAllIngredients()
        {
            var ingredientDbAccessMock = new Mock<IIngredientDbAccess>();
            var testee = new IngredientAction(ingredientDbAccessMock.Object, new Mapper().CreateMapper());

            testee.GetAllIngredients();

            ingredientDbAccessMock.Verify(x => x.GetIngredients(), Times.Once);
        }
    }
}