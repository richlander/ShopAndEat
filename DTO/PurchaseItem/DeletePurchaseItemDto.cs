namespace DTO.PurchaseItem
{
    public class DeletePurchaseItemDto
    {
        public DeletePurchaseItemDto(int purchaseItemId)
        {
            PurchaseItemId = purchaseItemId;
        }

        public int PurchaseItemId { get; }
    }
}