using System.Collections.Generic;
using System.Linq;
using DataLayer.EfClasses;

namespace BizLogic.Concrete
{
    public class OrderPurchaseItemsByStoreAction : IOrderPurchaseItemsByStoreAction
    {
        public IEnumerable<PurchaseItem> OrderPurchaseItemsByStore(Store store, IEnumerable<PurchaseItem> purchaseItems)
        {
            return store.Compartments.Join(purchaseItems,
                                           shoppingOrder => shoppingOrder.ArticleGroup,
                                           purchaseItem => purchaseItem.Article.ArticleGroup,
                                           (shoppingOrder, purchaseItem) => new { PurchaseItem = purchaseItem, shoppingOrder.Order })
                        .OrderBy(x => x.Order)
                        .Select(x => x.PurchaseItem);
        }
    }
}