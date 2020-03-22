using System.Collections.Generic;
using System.Linq;
using DataLayer.Core;

namespace BizLogic.Concrete
{
    public class GetRecipesForMealsAction : IGetRecipesForMealsAction
    {
        /// <inheritdoc />
        public IEnumerable<IRecipe> GetRecipesForMeals(IEnumerable<IMeal> meals)
        {
            return meals.Select(x => x.Recipe);
        }
    }
}