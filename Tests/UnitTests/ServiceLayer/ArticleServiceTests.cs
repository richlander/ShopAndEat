using BizLogic;
using DTO.Article;
using DTO.ArticleGroup;
using Moq;
using NUnit.Framework;
using ServiceLayer.Concrete;

namespace Tests.UnitTests.ServiceLayer
{
    [TestFixture]
    public class ArticleServiceTests
    {
        [Test]
        public void CreateArticle()
        {
            using var context = new InMemoryDbContext();
            var newArticleDto = new NewArticleDto("Cheese", new ExistingArticleGroupDto(3, "Diary"), true);
            var articleActionMock = new Mock<IArticleAction>();
            var testee = new ArticleService(articleActionMock.Object, context);

            testee.CreateArticle(newArticleDto);

            articleActionMock.Verify(x => x.CreateArticle(newArticleDto), Times.Once);
        }

        [Test]
        public void DeleteArticle()
        {
            using var context = new InMemoryDbContext();
            var deleteArticleGroupDto = new DeleteArticleDto(3);
            var articleActionMock = new Mock<IArticleAction>();
            var testee = new ArticleService(articleActionMock.Object, context);

            testee.DeleteArticle(deleteArticleGroupDto);

            articleActionMock.Verify(x => x.DeleteArticle(deleteArticleGroupDto), Times.Once);
        }

        [Test]
        public void GetAllArticles()
        {
            using var context = new InMemoryDbContext();
            var articleActionMock = new Mock<IArticleAction>();
            var testee = new ArticleService(articleActionMock.Object, context);

            testee.GetAllArticles();

            articleActionMock.Verify(x => x.GetAllArticles(), Times.Once);
        }
    }
}