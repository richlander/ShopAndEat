using System.Collections.Generic;
using DataLayer.EfClasses;

namespace BizLogic;

public interface IGetRecipesForMealsAction
{
    IEnumerable<Recipe> GetRecipesForMeals(IEnumerable<Meal> meals);
}