using System.Collections.Generic;
using DTO.Recipe;

namespace ServiceLayer
{
    internal interface IRecipeService
    {
        IEnumerable<ExistingRecipeDto> GetAllRecipes();
    }
}