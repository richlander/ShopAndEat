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

        [UsedImplicitly]
        private Article()
        {
        }

        public string Name { get; }

        public ArticleGroup ArticleGroup { get; }

        public bool IsInventory { get; }

        public int ArticleId { get; [UsedImplicitly] private set; }
    }
}