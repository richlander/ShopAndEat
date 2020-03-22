using System.Collections.Generic;

namespace DataLayer.Core
{
    public interface IStore
    {
        string Name { get; }

        IReadOnlyCollection<IShoppingOrder> Compartments { get; }

        void AddCompartment(IShoppingOrder compartment);

        void DeleteCompartment(IShoppingOrder compartment);
    }
}