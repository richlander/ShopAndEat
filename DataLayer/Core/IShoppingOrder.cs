namespace DataLayer.Core
{
    public interface IShoppingOrder
    {
        IArticleGroup ArticleGroup { get; }

        int Order { get; }
    }
}