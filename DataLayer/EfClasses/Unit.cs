using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class Unit
    {
        public Unit(string name)
        {
            Name = name;
        }

        [UsedImplicitly]
        private Unit()
        {
        }

        public string Name { get; }

        public int UnitId { get; [UsedImplicitly] private set; }
    }
}