using System.Linq;
using AutoMapper;
using DataLayer.EF;
using DataLayer.EfClasses;
using DTO.ArticleGroup;

namespace ServiceLayer.Concrete
{
    public class ArticleGroupService : IArticleGroupService
    {
        public ArticleGroupService(EfCoreContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }

        private EfCoreContext DbContext { get; }

        private IMapper Mapper { get; }

        /// <inheritdoc />
        public void Create(NewArticleGroupDto newArticleGroupDto)
        {
            var articleGroup = Mapper.Map<ArticleGroup>(newArticleGroupDto);
            DbContext.ArticleGroups.Add(articleGroup);
            DbContext.SaveChanges();
        }

        /// <inheritdoc />
        public void Delete(DeleteArticleGroupDto deleteArticleGroupDto)
        {
            var articleGroup = DbContext.ArticleGroups.Single(x => x.ArticleGroupId == deleteArticleGroupDto.ArticleGroupId);
            DbContext.ArticleGroups.Remove(articleGroup);
            DbContext.SaveChanges();
        }
    }
}