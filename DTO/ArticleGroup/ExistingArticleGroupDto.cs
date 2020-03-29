namespace DTO.ArticleGroup
{
    public class ExistingArticleGroupDto
    {
        public ExistingArticleGroupDto(in int articleGroupId, string name)
        {
            ArticleGroupId = articleGroupId;
            Name = name;
        }

        public int ArticleGroupId { get; }

        public string Name { get; }
    }
}