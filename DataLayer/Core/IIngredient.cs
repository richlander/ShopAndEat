using DataLayer.EfClasses;

namespace DataLayer.Core
{
    public interface IIngredient
    {
        string Name { get; }

        IIngredientGroup IngredientGroup { get; }

        Unit Unit { get; }

        bool IsInventory { get; }
    }
}