using DTO.Article;

namespace BizLogic
{
    public interface IArticleAction
    {
        void CreateArticle(NewArticleDto newArticleDto);

        void DeleteArticle(DeleteArticleDto deleteArticleDto);
    }
}