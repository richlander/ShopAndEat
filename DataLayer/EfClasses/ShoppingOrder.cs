using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class ShoppingOrder : IShoppingOrder
    {
        public ShoppingOrder(IArticleGroup articleGroup, in int order)
        {
            ArticleGroup = articleGroup;
            Order = order;
        }

        public IArticleGroup ArticleGroup { get; }

        public int Order { get; }
    }
}