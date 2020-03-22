using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Store : IStore
    {
        public Store(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}