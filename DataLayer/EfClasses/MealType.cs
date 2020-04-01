using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class MealType
    {
        public MealType(string name)
        {
            Name = name;
        }

        [UsedImplicitly]
        private MealType()
        {
        }

        public string Name { get; }

        public int MealTypeId { get; [UsedImplicitly] private set; }
    }
}