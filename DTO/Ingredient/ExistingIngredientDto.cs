using DTO.Article;
using DTO.Unit;

namespace DTO.Ingredient
{
    public class ExistingIngredientDto
    {
        public ExistingIngredientDto(ExistingArticleDto article,
                                     uint quantity,
                                     ExistingUnitDto unit,
                                     int ingredientId)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
            IngredientId = ingredientId;
        }

        public ExistingArticleDto Article { get; }

        public uint Quantity { get; }

        public ExistingUnitDto Unit { get; }

        public int IngredientId { get; }
    }
}