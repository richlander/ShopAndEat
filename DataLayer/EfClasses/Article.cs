using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class Article
    {
        public Article(string name, ArticleGroup articleGroup, bool isInventory)
        {
            Name = name;
            ArticleGroup = articleGroup;
            IsInventory = isInventory;
        }

        public Article()
        {
        }

        public string Name { get; [UsedImplicitly] private set; }

        public virtual ArticleGroup ArticleGroup { get; [UsedImplicitly] private set; }

        public bool IsInventory { get; [UsedImplicitly] private set; }

        public int ArticleId { get; [UsedImplicitly] private set; }
    }
}