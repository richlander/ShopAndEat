using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class ShoppingOrder : IShoppingOrder
    {
        public ShoppingOrder(ILocation location, IIngredientGroup ingredientGroup, in int order)
        {
            Location = location;
            IngredientGroup = ingredientGroup;
            Order = order;
        }

        public ILocation Location { get; }

        public IIngredientGroup IngredientGroup { get; }

        public int Order { get; }
    }
}