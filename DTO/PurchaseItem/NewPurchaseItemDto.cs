using DTO.Article;
using DTO.Unit;

namespace DTO.PurchaseItem
{
    public class NewPurchaseItemDto
    {
        public NewPurchaseItemDto(ExistingArticleDto article, ExistingUnitDto unit, double quantity)
        {
            Article = article;
            Unit = unit;
            Quantity = quantity;
        }

        public ExistingArticleDto Article { get; }

        public ExistingUnitDto Unit { get; }

        public double Quantity { get; }
    }
}