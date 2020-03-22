using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Recipe : IRecipe
    {
        private readonly List<IIngredient> _ingredients;

        public Recipe(string name, in int numberOfDays, IEnumerable<IIngredient> ingredients)
        {
            _ingredients = ingredients.ToList();
            Name = name;
            NumberOfDays = numberOfDays;
        }

        public string Name { get; }

        public int NumberOfDays { get; }

        public IReadOnlyCollection<IIngredient> Ingredients => new ReadOnlyCollection<IIngredient>(_ingredients.ToList());

        /// <inheritdoc />
        public void AddIngredient(IIngredient ingredient)
        {
            _ingredients.Add(ingredient);
        }

        /// <inheritdoc />
        public void DeleteIngredient(IIngredient ingredient)
        {
            if (_ingredients.Contains(ingredient))
            {
                _ingredients.Remove(ingredient);
            }
        }
    }
}