using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Purchase : IPurchase
    {
        private readonly IEnumerable<(IIngredient, int)> _ingredients;

        public Purchase(in DateTime from, in DateTime to, IEnumerable<(IIngredient, int)> ingredients)
        {
            _ingredients = ingredients;
            From = from;
            To = to;
        }

        public DateTime From { get; }

        public DateTime To { get; }

        public IReadOnlyCollection<(IIngredient, int)> Ingredients => new ReadOnlyCollection<(IIngredient, int)>(_ingredients.ToList());
    }
}