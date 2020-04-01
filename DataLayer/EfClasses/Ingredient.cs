using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class Ingredient
    {
        public Ingredient(Article article, uint quantity, Unit unit)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
        }

        [UsedImplicitly]
        private Ingredient()
        {
        }

        public Article Article { get; }

        public uint Quantity { get; }

        public Unit Unit { get; }

        public int IngredientId { get; [UsedImplicitly] private set; }
    }
}