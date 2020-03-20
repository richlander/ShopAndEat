using System.Collections.Generic;

namespace DataLayer.Core
{
    public interface ILocation
    {
        string Name { get; }

        IReadOnlyCollection<IShoppingOrder> ShoppingOrder { get; }
    }
}