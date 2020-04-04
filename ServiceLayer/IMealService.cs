using System.Collections.Generic;
using DTO.Meal;
using DTO.PurchaseItem;
using DTO.Recipe;
using DTO.Store;

namespace ServiceLayer
{
    internal interface IMealService
    {
        ExistingMealDto CreateMeal(NewMealDto newMealDto);

        IEnumerable<ExistingMealDto> GetAllMeals();

        IEnumerable<NewPurchaseItemDto> GetOrderedPurchaseItems(IEnumerable<ExistingRecipeDto> recipes, ExistingStoreDto store);
    }
}