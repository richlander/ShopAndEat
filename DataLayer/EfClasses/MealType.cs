using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class MealType:IMealType
    {
        public MealType(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}