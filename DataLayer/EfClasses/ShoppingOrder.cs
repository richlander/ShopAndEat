namespace DataLayer.EfClasses
{
    public class ShoppingOrder
    {
        public ShoppingOrder(ArticleGroup articleGroup, in int order)
        {
            ArticleGroup = articleGroup;
            Order = order;
        }

        public ArticleGroup ArticleGroup { get; }

        public int Order { get; }
    }
}