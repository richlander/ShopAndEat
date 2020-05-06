using JetBrains.Annotations;

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

        [UsedImplicitly]
        private PurchaseItem()
        {
        }

        public virtual Article Article { get; [UsedImplicitly] private set; }

        public virtual Unit Unit { get; [UsedImplicitly] private set; }

        public uint Quantity { get; [UsedImplicitly] private set; }

        public int PurchaseItemId { get; [UsedImplicitly] private set; }
    }
}