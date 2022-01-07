using AutoMapper;
using BizDbAccess;
using DataLayer.EfClasses;
using DTO.PurchaseItem;

namespace BizLogic.Concrete;

public class PurchaseItemAction : IPurchaseItemAction
{
    public PurchaseItemAction(IPurchaseItemDbAccess ingredientDbAccess, IMapper mapper)
    {
        PurchaseItemDbAccess = ingredientDbAccess;
        Mapper = mapper;
    }

    private IPurchaseItemDbAccess PurchaseItemDbAccess { get; }

    private IMapper Mapper { get; }

    /// <inheritdoc />
    public ExistingPurchaseItemDto CreatePurchaseItem(NewPurchaseItemDto newPurchaseItemDto)
    {
        var newPurchaseItem = Mapper.Map<PurchaseItem>(newPurchaseItemDto);
        var createdPurchaseItem = PurchaseItemDbAccess.AddPurchaseItem(newPurchaseItem);

        return Mapper.Map<ExistingPurchaseItemDto>(createdPurchaseItem);
    }

    /// <inheritdoc />
    public void DeletePurchaseItem(DeletePurchaseItemDto deletePurchaseItemDto)
    {
        PurchaseItemDbAccess.DeletePurchaseItem(PurchaseItemDbAccess.GetPurchaseItem(deletePurchaseItemDto.PurchaseItemId));
    }
}