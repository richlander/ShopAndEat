using DTO.ArticleGroup;

namespace DTO.Article
{
    public class ExistingArticleDto
    {
        public ExistingArticleDto(int articleId,
                                  string name,
                                  ExistingArticleGroupDto articleGroup,
                                  bool isInventory)
        {
            ArticleId = articleId;
            Name = name;
            ArticleGroup = articleGroup;
            IsInventory = isInventory;
        }

        public int ArticleId { get; }

        public string Name { get; }

        public ExistingArticleGroupDto ArticleGroup { get; }

        public bool IsInventory { get; }
    }
}