using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Ingredient : IIngredient
    {
        public Ingredient(string name,
                          IIngredientGroup ingredientGroup,
                          Unit unit,
                          in bool isInventory)
        {
            Name = name;
            IngredientGroup = ingredientGroup;
            Unit = unit;
            IsInventory = isInventory;
        }

        public string Name { get; }

        public IIngredientGroup IngredientGroup { get; }

        public Unit Unit { get; }

        public bool IsInventory { get; }
    }
}