using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Purchase : IPurchase
    {
        private readonly IEnumerable<(IIngredient, int)> _components;

        public Purchase(in DateTime from, in DateTime to, IEnumerable<(IIngredient, int)> components)
        {
            _components = components;
            From = from;
            To = to;
        }

        public DateTime From { get; }

        public DateTime To { get; }

        public IReadOnlyCollection<(IIngredient, int)> Components => new ReadOnlyCollection<(IIngredient, int)>(_components.ToList());
    }
}