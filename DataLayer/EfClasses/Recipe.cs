using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Recipe : IRecipe
    {
        private readonly IEnumerable<(IIngredient, int)> _ingredients;

        public Recipe(string name, in int numberOfDays, IEnumerable<(IIngredient, int)> ingredients)
        {
            _ingredients = ingredients;
            Name = name;
            NumberOfDays = numberOfDays;
        }

        public string Name { get; }

        public int NumberOfDays { get; }

        public IReadOnlyCollection<(IIngredient, int)> Ingredients => new ReadOnlyCollection<(IIngredient, int)>(_ingredients.ToList());
    }
}