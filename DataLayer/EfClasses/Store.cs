using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DataLayer.EfClasses
{
    public class Store
    {
        private readonly List<ShoppingOrder> _compartments;

        public Store(string name, IEnumerable<ShoppingOrder> compartments)
        {
            _compartments = compartments.ToList();
            Name = name;
        }

        public string Name { get; }

        public IReadOnlyCollection<ShoppingOrder> Compartments => new ReadOnlyCollection<ShoppingOrder>(_compartments);

        public void AddCompartment(ShoppingOrder compartment)
        {
            if (_compartments.Any(x => x.Order == compartment.Order))
            {
                throw new InvalidOperationException($"There is already a compartment with order '{compartment.Order}'");
            }
            else
            {
                _compartments.Add(compartment);
            }
        }

        public void DeleteCompartment(ShoppingOrder compartment)
        {
            if (_compartments.Contains(compartment))
            {
                _compartments.Remove(compartment);
            }
        }
    }
}