namespace DataLayer.EfClasses
{
    public class PurchaseItem
    {
        public PurchaseItem(Article article, uint quantity, Unit unit)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
        }

        public Article Article { get; }

        public Unit Unit { get; }

        public uint Quantity { get; }
    }
}