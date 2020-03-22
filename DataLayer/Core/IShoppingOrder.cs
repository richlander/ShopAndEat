namespace DataLayer.Core
{
    public interface IShoppingOrder
    {
        IStore Store { get; }

        IArticleGroup ArticleGroup { get; }

        int Order { get; }
    }
}