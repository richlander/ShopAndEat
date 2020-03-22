using System.Collections.Generic;
using DataLayer.Core;

namespace BizLogic
{
    public interface IGetRecipesForMealsAction
    {
        IEnumerable<IRecipe> GetRecipesForMeals(IEnumerable<IMeal> meals);
    }
}