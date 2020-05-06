using DTO.Article;
using DTO.Unit;

namespace DTO.Ingredient
{
    public class NewIngredientDto
    {
        public NewIngredientDto(ExistingArticleDto article, uint quantity, ExistingUnitDto unit)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
        }

        public ExistingArticleDto Article { get; }

        public uint Quantity { get; }

        public ExistingUnitDto Unit { get; }
    }
}