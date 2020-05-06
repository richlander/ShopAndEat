using DTO.Article;
using DTO.Unit;

namespace DTO.Ingredient
{
    public class NewIngredientDto
    {
        public NewIngredientDto(ExistingArticleDto article, double quantity, ExistingUnitDto unit)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
        }

        public ExistingArticleDto Article { get; }

        public double Quantity { get; }

        public ExistingUnitDto Unit { get; }
    }
}