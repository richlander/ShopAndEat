using DataLayer.EF;
using DataLayer.EfClasses;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using ServiceLayer.Concrete;
using ServiceLayer.DTO.ArticleGroup;
using ServiceLayer.Infrastructure;

namespace Tests.ServiceLayer
{
    [TestFixture]
    public class ArticleGroupServiceTests
    {
        [Test]
        public void CreateArticleGroup()
        {
            using var efCoreContext =
                new EfCoreContext(new DbContextOptionsBuilder<EfCoreContext>().UseInMemoryDatabase("inMemory").Options);
            var testee = new ArticleGroupService(efCoreContext, new Mapper().CreateMapper());
            var newArticleGroupDto = new NewArticleGroupDto("Vegetables");

            testee.Create(newArticleGroupDto);

            efCoreContext.ArticleGroups.Should().OnlyContain(x => x.Name == "Vegetables");
        }

        [Test]
        public void DeleteArticleGroup()
        {
            using var efCoreContext =
                new EfCoreContext(new DbContextOptionsBuilder<EfCoreContext>().UseInMemoryDatabase("inMemory").Options);
            var existingArticleGroup = efCoreContext.ArticleGroups.Add(new ArticleGroup("Vegetables"));
            efCoreContext.SaveChanges();
            var testee = new ArticleGroupService(efCoreContext, new Mapper().CreateMapper());
            var deleteArticleGroupDto = new DeleteArticleGroupDto(existingArticleGroup.Entity.ArticleGroupId);

            testee.Delete(deleteArticleGroupDto);

            efCoreContext.ArticleGroups.Should().NotContain(x => x.Name == "Vegetables");
        }
    }
}