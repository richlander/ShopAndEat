using DataLayer.EfClasses;

namespace DataLayer.Core
{
    public interface IIngredient
    {
        string Name { get; }

        IIngredientGroup IngredientGroup { get; }

        IUnit Unit { get; }

        bool IsInventory { get; }
    }
}