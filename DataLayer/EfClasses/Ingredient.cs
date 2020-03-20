using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Ingredient : IIngredient
    {
        public Ingredient(string name,
                          IIngredientGroup ingredientGroup,
                          IUnit unit,
                          in bool isInventory)
        {
            Name = name;
            IngredientGroup = ingredientGroup;
            Unit = unit;
            IsInventory = isInventory;
        }

        public string Name { get; }

        public IIngredientGroup IngredientGroup { get; }

        public IUnit Unit { get; }

        public bool IsInventory { get; }
    }
}