using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Store : IStore
    {
        private readonly List<IShoppingOrder> _compartments;

        public Store(string name, IEnumerable<IShoppingOrder> compartments)
        {
            _compartments = compartments.ToList();
            Name = name;
        }

        public string Name { get; }

        public IReadOnlyCollection<IShoppingOrder> Compartments => new ReadOnlyCollection<IShoppingOrder>(_compartments);

        /// <inheritdoc />
        public void AddCompartment(IShoppingOrder compartment)
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

        /// <inheritdoc />
        public void DeleteCompartment(IShoppingOrder compartment)
        {
            if (_compartments.Contains(compartment))
            {
                _compartments.Remove(compartment);
            }
        }
    }
}