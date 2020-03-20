using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Recipe : IRecipe
    {
        private readonly List<(IIngredient, int)> _components;

        public Recipe(string name, in int numberOfDays, IEnumerable<(IIngredient, int)> components)
        {
            _components = components.ToList();
            Name = name;
            NumberOfDays = numberOfDays;
        }

        public string Name { get; }

        public int NumberOfDays { get; }

        public IReadOnlyCollection<(IIngredient, int)> Components => new ReadOnlyCollection<(IIngredient, int)>(_components.ToList());

        /// <inheritdoc />
        public void AddComponent((IIngredient, int) component)
        {
            _components.Add(component);
        }

        /// <inheritdoc />
        public void DeleteComponent((IIngredient, int) component)
        {
            if (_components.Contains(component))
            {
                _components.Remove(component);
            }
        }
    }
}