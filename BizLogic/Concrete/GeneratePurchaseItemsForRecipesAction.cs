using System.Collections.Generic;
using System.Linq;
using DataLayer.Core;
using DataLayer.EfClasses;

namespace BizLogic.Concrete
{
    public class GeneratePurchaseItemsForRecipesAction : IGeneratePurchaseItemsForRecipesAction
    {
        /// <inheritdoc />
        public IEnumerable<IPurchaseItem> GeneratePurchaseItems(IEnumerable<IRecipe> recipes)
        {
            return recipes.Select(recipe => recipe.Ingredients)
                          .SelectMany(ingredients => ingredients)
                          .GroupBy(x => new { x.Article, x.Unit })
                          .Select(y => new PurchaseItem(y.Key.Article, (uint)y.Sum(z => z.Quantity), y.Key.Unit));
        }
    }
}