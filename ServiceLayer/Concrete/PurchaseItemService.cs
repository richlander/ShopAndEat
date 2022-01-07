using BizLogic;
using DataLayer.EF;
using DTO.PurchaseItem;

namespace ServiceLayer.Concrete;

public class PurchaseItemService : IPurchaseItemService
{
    public PurchaseItemService(IPurchaseItemAction purchaseItemAction, EfCoreContext context)
    {
        PurchaseItemAction = purchaseItemAction;
        Context = context;
    }

    private IPurchaseItemAction PurchaseItemAction { get; }

    private EfCoreContext Context { get; }

    /// <inheritdoc />
    public ExistingPurchaseItemDto CreatePurchaseItem(NewPurchaseItemDto newPurchaseItemDto)
    {
        var createdPurchaseItemDto = PurchaseItemAction.CreatePurchaseItem(newPurchaseItemDto);
        Context.SaveChanges();

        return createdPurchaseItemDto;
    }

    /// <inheritdoc />
    public void DeletePurchaseItem(DeletePurchaseItemDto deletePurchaseItemDto)
    {
        PurchaseItemAction.DeletePurchaseItem(deletePurchaseItemDto);
        Context.SaveChanges();
    }
}