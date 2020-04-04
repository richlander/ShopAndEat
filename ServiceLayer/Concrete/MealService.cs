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
            var existingMealDto = SimpleCrudHelper.Create<NewMealDto, Meal, ExistingMealDto>(newMealDto);
            Context.SaveChanges();

            return existingMealDto;
        }

        /// <inheritdoc />
        public IEnumerable<ExistingMealDto> GetAllMeals()
        {
            return SimpleCrudHelper.GetAllAsDto<Meal, ExistingMealDto>();
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
    }
}