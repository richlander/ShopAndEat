using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class IngredientGroup : IIngredientGroup
    {
        public IngredientGroup(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}