using System.Collections.Generic;
using DataLayer.EfClasses;
using DTO.Recipe;

namespace ServiceLayer.Concrete
{
    public class RecipeService : IRecipeService
    {
        public RecipeService(SimpleCrudHelper simpleCrudHelper)
        {
            SimpleCrudHelper = simpleCrudHelper;
        }

        private SimpleCrudHelper SimpleCrudHelper { get; }

        /// <inheritdoc />
        public IEnumerable<ExistingRecipeDto> GetAllRecipes()
        {
            return SimpleCrudHelper.GetAllAsDto<Recipe, ExistingRecipeDto>();
        }
    }
}