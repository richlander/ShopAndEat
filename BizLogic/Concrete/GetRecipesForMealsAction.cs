using System.Collections.Generic;
using System.Linq;
using DataLayer.EfClasses;

namespace BizLogic.Concrete;

public class GetRecipesForMealsAction : IGetRecipesForMealsAction
{
    /// <inheritdoc />
    public IEnumerable<Recipe> GetRecipesForMeals(IEnumerable<Meal> meals)
    {
        return meals.Select(x => x.Recipe);
    }
}