namespace DataLayer.Core
{
    public interface IPurchaseItem
    {
        IArticle Article { get; }

        int Quantity { get; }

        IUnit Unit { get; }
    }
}