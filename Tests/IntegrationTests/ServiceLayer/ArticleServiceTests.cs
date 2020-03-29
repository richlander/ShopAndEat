using BizDbAccess.Concrete;
using BizLogic.Concrete;
using DataLayer.EfClasses;
using DTO;
using DTO.Article;
using DTO.ArticleGroup;
using FluentAssertions;
using NUnit.Framework;
using ServiceLayer.Concrete;

namespace Tests.IntegrationTests.ServiceLayer
{
    [TestFixture]
    public class ArticleServiceTests
    {
        [Test]
        public void CreateArticle()
        {
            using var context = new InMemoryDbContext();
            var vegetables = context.ArticleGroups.Add(new ArticleGroup("Vegetables"));
            context.SaveChanges();
            var testee = new ArticleService(new ArticleAction(new ArticleDbAccess(context), new Mapper().CreateMapper()), context);

            testee.CreateArticle(new NewArticleDto("Tomato",
                                                   new ExistingArticleGroupDto(vegetables.Entity.ArticleGroupId, "Vegetables"),
                                                   false));

            context.Articles.Should().Contain(x => x.Name == "Tomato");
        }
    }
}