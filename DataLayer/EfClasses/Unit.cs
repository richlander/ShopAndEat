using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Unit : IUnit
    {
        public Unit(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}