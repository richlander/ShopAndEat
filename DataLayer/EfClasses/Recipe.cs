using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        [UsedImplicitly]
        private Recipe()
        {
        }

        public string Name { get; }

        public int NumberOfDays { get; }

        public IReadOnlyCollection<Ingredient> Ingredients => new ReadOnlyCollection<Ingredient>(_ingredients.ToList());

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