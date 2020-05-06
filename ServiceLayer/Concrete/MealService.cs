using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BizLogic;
using DataLayer.EF;
using DataLayer.EfClasses;
using DTO.Meal;
using DTO.PurchaseItem;
using DTO.Recipe;
using DTO.Store;

namespace ServiceLayer.Concrete
{
    public class MealService : IMealService
    {
        public MealService(IGeneratePurchaseItemsForRecipesAction generatePurchaseItemsForRecipesAction,
                           IOrderPurchaseItemsByStoreAction orderPurchaseItemsByStoreAction,
                           EfCoreContext context,
                           SimpleCrudHelper simpleCrudHelper,
                           IMapper mapper)
        {
            GeneratePurchaseItemsForRecipesAction = generatePurchaseItemsForRecipesAction;
            OrderPurchaseItemsByStoreAction = orderPurchaseItemsByStoreAction;
            Context = context;
            SimpleCrudHelper = simpleCrudHelper;
            Mapper = mapper;
        }

        private IGeneratePurchaseItemsForRecipesAction GeneratePurchaseItemsForRecipesAction { get; }

        private IOrderPurchaseItemsByStoreAction OrderPurchaseItemsByStoreAction { get; }

        private EfCoreContext Context { get; }

        private SimpleCrudHelper SimpleCrudHelper { get; }

        private IMapper Mapper { get; }

        /// <inheritdoc />
        public ExistingMealDto CreateMeal(NewMealDto newMealDto)
        {
            // TODO mu88: Try to avoid this manual mapping logic
            var recipe = SimpleCrudHelper.Find<Recipe>(newMealDto.Recipe.RecipeId);
            var mealType = SimpleCrudHelper.Find<MealType>(newMealDto.MealType.MealTypeId);
            var newMeal = new Meal(newMealDto.Day,mealType,recipe);
            var createdMeal = Context.Meals.Add(newMeal);
            Context.SaveChanges();

            return Mapper.Map<ExistingMealDto>(createdMeal.Entity);
        }

        /// <inheritdoc />
        public IEnumerable<ExistingMealDto> GetFutureMeals()
        {
            var allMeals = SimpleCrudHelper.GetAllAsDto<Meal, ExistingMealDto>();

            return allMeals.Where(x => IsInFuture(x.Day));
        }

        /// <inheritdoc />
        public IEnumerable<NewPurchaseItemDto> GetOrderedPurchaseItems(IEnumerable<ExistingRecipeDto> existingRecipeDtos,
                                                                       ExistingStoreDto existingStoreDto)
        {
            var recipes = SimpleCrudHelper.FindMany<Recipe>(existingRecipeDtos.Select(x => x.RecipeId));
            var store = SimpleCrudHelper.Find<Store>(existingStoreDto.StoreId);

            var orderedPurchaseItemsByStore =
                OrderPurchaseItemsByStoreAction.OrderPurchaseItemsByStore(store,
                                                                          GeneratePurchaseItemsForRecipesAction
                                                                              .GeneratePurchaseItems(recipes));

            return Mapper.Map<IEnumerable<NewPurchaseItemDto>>(orderedPurchaseItemsByStore);
        }

        private bool IsInFuture(DateTime mealDate)
        {
            // only compare year, month and day - we don't need hours and minutes
            var now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            
            return mealDate >= now;
        }
    }
}