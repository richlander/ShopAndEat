using DTO.Article;
using DTO.Unit;

namespace DTO.PurchaseItem;

public class ExistingPurchaseItemDto
{
    public ExistingPurchaseItemDto(ExistingArticleDto article,
                                   ExistingUnitDto unit,
                                   uint quantity,
                                   int purchaseItemId)
    {
        Article = article;
        Unit = unit;
        Quantity = quantity;
        PurchaseItemId = purchaseItemId;
    }

    public ExistingArticleDto Article { get; }

    public ExistingUnitDto Unit { get; }

    public uint Quantity { get; }

    public int PurchaseItemId { get; }
}