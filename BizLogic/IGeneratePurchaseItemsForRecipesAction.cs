using System.Collections.Generic;
using DataLayer.Core;

namespace BizLogic
{
    public interface IGeneratePurchaseItemsForRecipesAction
    {
        IEnumerable<IPurchaseItem> GeneratePurchaseItems(IEnumerable<IRecipe> recipes);
    }
}