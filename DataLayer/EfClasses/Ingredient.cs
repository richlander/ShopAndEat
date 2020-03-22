using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Ingredient : IIngredient
    {
        public Ingredient(IArticle article, in uint quantity, IUnit unit)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
        }

        public IArticle Article { get; }

        public uint Quantity { get; }

        public IUnit Unit { get; }
    }
}