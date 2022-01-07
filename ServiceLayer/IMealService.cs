using System.Collections.Generic;
using DTO.Meal;
using DTO.PurchaseItem;
using DTO.Recipe;
using DTO.Store;

namespace ServiceLayer;

public interface IMealService
{
    ExistingMealDto CreateMeal(NewMealDto newMealDto);

    IEnumerable<ExistingMealDto> GetFutureMeals();

    IEnumerable<NewPurchaseItemDto> GetOrderedPurchaseItems(IEnumerable<ExistingRecipeDto> recipes, ExistingStoreDto store);
        
    IEnumerable<NewPurchaseItemDto> GetOrderedPurchaseItems(ExistingStoreDto store);

    void DeleteMeal(DeleteMealDto mealToDelete);
}