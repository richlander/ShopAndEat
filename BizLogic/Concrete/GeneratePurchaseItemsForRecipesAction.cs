using System.Collections.Generic;
using System.Linq;
using DataLayer.EfClasses;

namespace BizLogic.Concrete
{
    public class GeneratePurchaseItemsForRecipesAction : IGeneratePurchaseItemsForRecipesAction
    {
        /// <inheritdoc />
        public IEnumerable<PurchaseItem> GeneratePurchaseItems(IEnumerable<Recipe> recipes)
        {
            return recipes.Select(recipe => recipe.Ingredients)
                          .SelectMany(ingredients => ingredients)
                          .GroupBy(x => new { x.Article, x.Unit })
                          .Select(y => new PurchaseItem(y.Key.Article, y.Sum(z => z.Quantity), y.Key.Unit));
        }
    }
}