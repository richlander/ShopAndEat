using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class ShoppingOrder
    {
        public ShoppingOrder(ArticleGroup articleGroup, in int order)
        {
            ArticleGroup = articleGroup;
            Order = order;
        }

        [UsedImplicitly]
        private ShoppingOrder()
        {
        }

        public ArticleGroup ArticleGroup { get; }

        public int Order { get; }

        public int ShoppingOrderId { get; [UsedImplicitly] private set; }
    }
}