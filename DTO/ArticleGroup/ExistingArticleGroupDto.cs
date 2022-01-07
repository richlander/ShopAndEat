namespace DTO.ArticleGroup;

public class ExistingArticleGroupDto
{
    public ExistingArticleGroupDto(int articleGroupId, string name)
    {
        ArticleGroupId = articleGroupId;
        Name = name;
    }

    public int ArticleGroupId { get; }

    public string Name { get; }
}