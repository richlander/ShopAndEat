namespace DTO.Article;

public class DeleteArticleDto
{
    public int ArticleId { get; }

    public DeleteArticleDto(in int articleId)
    {
        ArticleId = articleId;
    }
}