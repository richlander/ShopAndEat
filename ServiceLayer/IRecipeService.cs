using System.Collections.Generic;
using DTO.Recipe;

namespace ServiceLayer
{
    public interface IRecipeService
    {
        IEnumerable<ExistingRecipeDto> GetAllRecipes();

        void CreateNewRecipe(NewRecipeDto newRecipe);
    }
}