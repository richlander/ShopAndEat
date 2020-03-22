using System.Collections.Generic;
using DataLayer.Core;

namespace BizLogic
{
    public interface IOrderPurchaseItemsByStoreAction
    {
        IEnumerable<IPurchaseItem> OrderPurchaseItemsByStore(IStore store, IEnumerable<IPurchaseItem> purchaseItems);
    }
}