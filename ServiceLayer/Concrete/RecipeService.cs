using System.Collections.Generic;
using DataLayer.EF;
using DataLayer.EfClasses;
using DTO.Recipe;

namespace ServiceLayer.Concrete
{
    public class RecipeService : IRecipeService
    {
        public RecipeService(SimpleCrudHelper simpleCrudHelper, EfCoreContext context)
        {
            SimpleCrudHelper = simpleCrudHelper;
            Context = context;
        }

        private SimpleCrudHelper SimpleCrudHelper { get; }

        private EfCoreContext Context { get; }

        /// <inheritdoc />
        public IEnumerable<ExistingRecipeDto> GetAllRecipes()
        {
            return SimpleCrudHelper.GetAllAsDto<Recipe, ExistingRecipeDto>();
        }

        /// <inheritdoc />
        public void CreateNewRecipe(NewRecipeDto newRecipeDto)
        {
            var newIngredients = new List<Ingredient>();
            foreach (var newIngredientDto in newRecipeDto.Ingredients)
            {
                var unit = SimpleCrudHelper.Find<Unit>(newIngredientDto.Unit.UnitId);
                var article = SimpleCrudHelper.Find<Article>(newIngredientDto.Article.ArticleId);
                newIngredients.Add(Context.Ingredients.Add(new Ingredient(article, newIngredientDto.Quantity, unit)).Entity);
            }

            var newRecipe = new Recipe(newRecipeDto.Name, newRecipeDto.NumberOfDays, newIngredients);
            Context.Recipes.Add(newRecipe);
            Context.SaveChanges();
        }
    }
}