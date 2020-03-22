using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class PurchaseItem : IPurchaseItem
    {
        public PurchaseItem(IArticle article, uint quantity, IUnit unit)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
        }

        public IArticle Article { get; }

        public IUnit Unit { get; }

        public uint Quantity { get; }
    }
}