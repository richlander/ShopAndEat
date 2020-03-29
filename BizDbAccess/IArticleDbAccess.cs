using DataLayer.EfClasses;

namespace BizDbAccess
{
    public interface IArticleDbAccess
    {
        void AddArticle(Article article);

        void DeleteArticle(Article article);

        Article GetArticle(int articleId);
    }
}