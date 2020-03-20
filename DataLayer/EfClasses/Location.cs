using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Location : ILocation
    {
        public Location(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}