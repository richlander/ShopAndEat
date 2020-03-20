namespace DataLayer.Core
{
    public interface IShoppingOrder
    {
        ILocation Location { get; }

        IIngredientGroup IngredientGroup { get; }

        int Order { get; }
    }
}