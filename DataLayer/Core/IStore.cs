using System.Collections.Generic;

namespace DataLayer.Core
{
    public interface IStore
    {
        string Name { get; }

        IReadOnlyCollection<IShoppingOrder> Compartments { get; }
    }
}