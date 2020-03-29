namespace ServiceLayer.DTO.ArticleGroup
{
    public class NewArticleGroupDto
    {
        public NewArticleGroupDto(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}