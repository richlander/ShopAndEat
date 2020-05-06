using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class MealType
    {
        public MealType(string name)
        {
            Name = name;
        }

        public MealType()
        {
        }

        public string Name { get; [UsedImplicitly] private set; }

        public int MealTypeId { get; [UsedImplicitly] private set; }
    }
}