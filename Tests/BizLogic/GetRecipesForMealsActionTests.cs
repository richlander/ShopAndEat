using BizLogic.Concrete;
using DataLayer.Core;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Tests.BizLogic
{
    [TestFixture]
    public class GetRecipesForMealsActionTests
    {
        [Test]
        public void GetRecipesForMeals()
        {
            var mealMock1 = new Mock<IMeal>();
            mealMock1.Setup(x => x.Recipe).Returns(new Mock<IRecipe>().Object);
            var mealMock2 = new Mock<IMeal>();
            mealMock2.Setup(x => x.Recipe).Returns(new Mock<IRecipe>().Object);
            var meals = new[] { mealMock1.Object, mealMock2.Object };
            var testee = new GetRecipesForMealsAction();

            var results = testee.GetRecipesForMeals(meals);

            results.Should().HaveCount(2);
        }
    }
}