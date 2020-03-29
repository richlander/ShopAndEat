using DataLayer.EfClasses;
using DTO;
using DTO.ArticleGroup;
using FluentAssertions;
using NUnit.Framework;
using ServiceLayer.Concrete;

namespace Tests.UnitTests.ServiceLayer
{
    [TestFixture]
    public class ArticleGroupServiceTests
    {
        [Test]
        public void CreateArticleGroup()
        {
            using var context = new InMemoryDbContext();
            var testee = new ArticleGroupService(context, new Mapper().CreateMapper());
            var newArticleGroupDto = new NewArticleGroupDto("Vegetables");

            testee.Create(newArticleGroupDto);

            context.ArticleGroups.Should().Contain(x => x.Name == "Vegetables");
        }

        [Test]
        public void DeleteArticleGroup()
        {
            using var context = new InMemoryDbContext();
            var existingArticleGroup = context.ArticleGroups.Add(new ArticleGroup("Vegetables"));
            context.SaveChanges();
            var testee = new ArticleGroupService(context, new Mapper().CreateMapper());
            var deleteArticleGroupDto = new DeleteArticleGroupDto(existingArticleGroup.Entity.ArticleGroupId);

            testee.Delete(deleteArticleGroupDto);

            context.ArticleGroups.Should().NotContain(x => x.Name == "Vegetables");
        }
    }
}