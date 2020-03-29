namespace ServiceLayer.DTO.ArticleGroup
{
    public class DeleteArticleGroupDto
    {
        public DeleteArticleGroupDto(int articleGroupId)
        {
            ArticleGroupId = articleGroupId;
        }

        public int ArticleGroupId { get; }
    }
}