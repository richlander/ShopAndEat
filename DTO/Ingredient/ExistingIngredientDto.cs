using DTO.Article;
using DTO.Unit;

namespace DTO.Ingredient
{
    public class ExistingIngredientDto
    {
        public ExistingIngredientDto(ExistingArticleDto article,
                                     double quantity,
                                     ExistingUnitDto unit,
                                     int ingredientId)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
            IngredientId = ingredientId;
        }

        public ExistingArticleDto Article { get; }

        public double Quantity { get; }

        public ExistingUnitDto Unit { get; }

        public int IngredientId { get; }
    }
}