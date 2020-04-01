using System.Collections.Generic;
using BizLogic;
using DataLayer.EF;
using DTO.Article;

namespace ServiceLayer.Concrete
{
    public class ArticleService : IArticleService
    {
        public ArticleService(IArticleAction articleAction, EfCoreContext context)
        {
            ArticleAction = articleAction;
            Context = context;
        }

        private IArticleAction ArticleAction { get; }

        private EfCoreContext Context { get; }

        public ExistingArticleDto CreateArticle(NewArticleDto newArticleDto)
        {
            var createdArticle = ArticleAction.CreateArticle(newArticleDto);
            Context.SaveChanges();

            return createdArticle;
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