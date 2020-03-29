using System.Linq;
using DataLayer.EF;
using DataLayer.EfClasses;

namespace BizDbAccess.Concrete
{
    public class ArticleDbAccess : IArticleDbAccess
    {
        public ArticleDbAccess(EfCoreContext context)
        {
            Context = context;
        }

        private EfCoreContext Context { get; }

        /// <inheritdoc />
        public void AddArticle(Article article)
        {
            Context.Articles.Add(article);
        }

        /// <inheritdoc />
        public void DeleteArticle(Article article)
        {
            Context.Articles.Remove(article);
        }

        /// <inheritdoc />
        public Article GetArticle(int articleId)
        {
            return Context.Articles.Single(x => x.ArticleId == articleId);
        }
    }
}