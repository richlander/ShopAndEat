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

        public void CreateArticle(NewArticleDto newArticleDto)
        {
            ArticleAction.CreateArticle(newArticleDto);
            Context.SaveChanges();
        }

        public void DeleteArticle(DeleteArticleDto deleteArticleDto)
        {
            ArticleAction.DeleteArticle(deleteArticleDto);
            Context.SaveChanges();
        }
    }
}