using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Location : ILocation
    {
        private readonly IEnumerable<IShoppingOrder> _shoppingOrder;

        public Location(string name, IEnumerable<IShoppingOrder> shoppingOrder)
        {
            _shoppingOrder = shoppingOrder;
            Name = name;
        }

        public string Name { get; }

        public IReadOnlyCollection<IShoppingOrder> ShoppingOrder => new ReadOnlyCollection<IShoppingOrder>(_shoppingOrder.ToList());
    }
}