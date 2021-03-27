using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class Recipe
    {
        public Recipe(string name, int numberOfDays, IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients.ToList();
            Name = name;
            NumberOfDays = numberOfDays;
        }

        public Recipe()
        {
        }

        public virtual IEnumerable<Ingredient> Ingredients { get; set; }

        public string Name { get; set; }

        public int NumberOfDays { get; set; }

        public int RecipeId { get; [UsedImplicitly] private set; }
    }
}