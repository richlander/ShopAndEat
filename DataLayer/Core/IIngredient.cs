namespace DataLayer.Core
{
    public interface IIngredient
    {
        IArticle Article { get; }

        uint Quantity { get; }

        IUnit Unit { get; }
    }
}