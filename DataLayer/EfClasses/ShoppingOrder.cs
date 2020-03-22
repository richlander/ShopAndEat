using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class ShoppingOrder : IShoppingOrder
    {
        public ShoppingOrder(IStore store, IArticleGroup articleGroup, in int order)
        {
            Store = store;
            ArticleGroup = articleGroup;
            Order = order;
        }

        public IStore Store { get; }

        public IArticleGroup ArticleGroup { get; }

        public int Order { get; }
    }
}