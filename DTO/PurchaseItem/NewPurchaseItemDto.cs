using DTO.Article;
using DTO.Unit;

namespace DTO.PurchaseItem
{
    public class NewPurchaseItemDto
    {
        public NewPurchaseItemDto(ExistingArticleDto article, ExistingUnitDto unit, uint quantity)
        {
            Article = article;
            Unit = unit;
            Quantity = quantity;
        }

        public ExistingArticleDto Article { get; }

        public ExistingUnitDto Unit { get; }

        public uint Quantity { get; }
    }
}