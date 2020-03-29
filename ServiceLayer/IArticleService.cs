using DTO.Article;

namespace ServiceLayer
{
    public interface IArticleService
    {
        void CreateArticle(NewArticleDto newArticleDto);

        void DeleteArticle(DeleteArticleDto deleteArticleDto);
    }
}