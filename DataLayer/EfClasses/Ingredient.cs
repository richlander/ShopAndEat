namespace DataLayer.EfClasses
{
    public class Ingredient
    {
        public Ingredient(Article article, in uint quantity, Unit unit)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
        }

        public Article Article { get; }

        public uint Quantity { get; }

        public Unit Unit { get; }
    }
}