using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class Recipe
    {
        private readonly List<Ingredient> _ingredients;

        public Recipe(string name, int numberOfDays, IEnumerable<Ingredient> ingredients)
        {
            _ingredients = ingredients.ToList();
            Name = name;
            NumberOfDays = numberOfDays;
        }

        public Recipe()
        {
        }

        public virtual IEnumerable<Ingredient> Ingredients => _ingredients;

        public string Name { get; [UsedImplicitly] private set; }

        public int NumberOfDays { get; [UsedImplicitly] private set; }

        public int RecipeId { get; [UsedImplicitly] private set; }

        public void AddIngredient(Ingredient ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            if (_ingredients.Contains(ingredient))
            {
                _ingredients.Remove(ingredient);
            }
        }
    }
}