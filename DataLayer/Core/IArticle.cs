namespace DataLayer.Core
{
    public interface IArticle
    {
        string Name { get; }

        IArticleGroup ArticleGroup { get; }

        bool IsInventory { get; }
    }
}