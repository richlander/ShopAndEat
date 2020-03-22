namespace DataLayer.Core
{
    public interface IPurchaseItem
    {
        IArticle Article { get; }

        uint Quantity { get; }

        IUnit Unit { get; }
    }
}