using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Article : IArticle
    {
        public Article(string name, IArticleGroup articleGroup, in bool isInventory)
        {
            Name = name;
            ArticleGroup = articleGroup;
            IsInventory = isInventory;
        }

        public string Name { get; }

        public IArticleGroup ArticleGroup { get; }

        public bool IsInventory { get; }
    }
}