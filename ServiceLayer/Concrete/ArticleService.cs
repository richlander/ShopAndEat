using System.Collections.Generic;
using AutoMapper;
using BizLogic;
using DataLayer.EF;
using DataLayer.EfClasses;
using DTO.Article;

namespace ServiceLayer.Concrete
{
    public class ArticleService : IArticleService
    {
        public ArticleService(IArticleAction articleAction,
                              EfCoreContext context,
                              IMapper mapper,
                              SimpleCrudHelper simpleCrudHelper)
        {
            ArticleAction = articleAction;
            Context = context;
            Mapper = mapper;
            SimpleCrudHelper = simpleCrudHelper;
        }

        private SimpleCrudHelper SimpleCrudHelper { get; }

        private IMapper Mapper { get; }

        private IArticleAction ArticleAction { get; }

        private EfCoreContext Context { get; }

        public ExistingArticleDto CreateArticle(NewArticleDto newArticleDto)
        {
            // TODO mu88: Try to avoid this manual mapping logic
            var articleGroup = SimpleCrudHelper.Find<ArticleGroup>(newArticleDto.ArticleGroup.ArticleGroupId);
            var newArticle = new Article(newArticleDto.Name, articleGroup, newArticleDto.IsInventory);
            var createdArticle = Context.Articles.Add(newArticle);
            Context.SaveChanges();

            return Mapper.Map<ExistingArticleDto>(createdArticle.Entity);
        }

        public void DeleteArticle(DeleteArticleDto deleteArticleDto)
        {
            ArticleAction.DeleteArticle(deleteArticleDto);
            Context.SaveChanges();
        }

        /// <inheritdoc />
        public IEnumerable<ExistingArticleDto> GetAllArticles()
        {
            return ArticleAction.GetAllArticles();
        }
    }
}