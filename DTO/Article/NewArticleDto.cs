using DTO.ArticleGroup;

namespace DTO.Article
{
    public class NewArticleDto
    {
        public NewArticleDto(string name, ExistingArticleGroupDto articleGroup, bool isInventory)
        {
            Name = name;
            ArticleGroup = articleGroup;
            IsInventory = isInventory;
        }

        public string Name { get; }

        public ExistingArticleGroupDto ArticleGroup { get; }

        public bool IsInventory { get; }
    }
}