using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Store : IStore
    {
        private readonly IEnumerable<IShoppingOrder> _compartments;

        public Store(string name, IEnumerable<IShoppingOrder> compartments)
        {
            _compartments = compartments;
            Name = name;
        }

        public string Name { get; }

        public IReadOnlyCollection<IShoppingOrder> Compartments => new ReadOnlyCollection<IShoppingOrder>(_compartments.ToList());
    }
}