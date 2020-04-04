using AutoMapper;
using DTO.Article;
using DTO.ArticleGroup;
using DTO.Ingredient;
using DTO.Meal;
using DTO.MealType;
using DTO.PurchaseItem;
using DTO.Recipe;
using DTO.Unit;

namespace DTO
{
    public class Mapper
    {
        public IMapper CreateMapper()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.CreateMap<NewArticleGroupDto, DataLayer.EfClasses.ArticleGroup>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                config.CreateMap<NewMealTypeDto, DataLayer.EfClasses.MealType>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                config.CreateMap<NewUnitDto, DataLayer.EfClasses.Unit>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                config.CreateMap<NewIngredientDto, DataLayer.EfClasses.Ingredient>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                config.CreateMap<NewArticleDto, DataLayer.EfClasses.Article>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                config.CreateMap<NewPurchaseItemDto, DataLayer.EfClasses.PurchaseItem>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                config.CreateMap<NewMealDto, DataLayer.EfClasses.Meal>().IgnoreAllPropertiesWithAnInaccessibleSetter();

                config.CreateMap<ExistingArticleGroupDto, DataLayer.EfClasses.ArticleGroup>()
                      .IgnoreAllPropertiesWithAnInaccessibleSetter()
                      .ReverseMap();
                config.CreateMap<ExistingMealTypeDto, DataLayer.EfClasses.MealType>()
                      .IgnoreAllPropertiesWithAnInaccessibleSetter()
                      .ReverseMap();
                config.CreateMap<ExistingUnitDto, DataLayer.EfClasses.Unit>().IgnoreAllPropertiesWithAnInaccessibleSetter().ReverseMap();
                config.CreateMap<ExistingArticleDto, DataLayer.EfClasses.Article>()
                      .IgnoreAllPropertiesWithAnInaccessibleSetter()
                      .ReverseMap();
                config.CreateMap<ExistingIngredientDto, DataLayer.EfClasses.Ingredient>()
                      .IgnoreAllPropertiesWithAnInaccessibleSetter()
                      .ReverseMap();
                config.CreateMap<ExistingPurchaseItemDto, DataLayer.EfClasses.PurchaseItem>()
                      .IgnoreAllPropertiesWithAnInaccessibleSetter()
                      .ReverseMap();
                config.CreateMap<ExistingMealDto, DataLayer.EfClasses.Meal>().IgnoreAllPropertiesWithAnInaccessibleSetter().ReverseMap();
                config.CreateMap<ExistingRecipeDto, DataLayer.EfClasses.Recipe>()
                      .IgnoreAllPropertiesWithAnInaccessibleSetter()
                      .ReverseMap();
            });
            configuration.AssertConfigurationIsValid();

            return configuration.CreateMapper();
        }
    }
}