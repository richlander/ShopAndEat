using System.Collections.Generic;
using DTO.Ingredient;

namespace ServiceLayer
{
    internal interface IIngredientService
    {
        ExistingIngredientDto CreateIngredient(NewIngredientDto newIngredientDto);

        void DeleteIngredient(DeleteIngredientDto deleteIngredientDto);

        IEnumerable<ExistingIngredientDto> GetAllIngredients();
    }
}