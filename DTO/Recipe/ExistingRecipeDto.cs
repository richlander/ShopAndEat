using System.Collections.Generic;
using DTO.Ingredient;

namespace DTO.Recipe
{
    public class ExistingRecipeDto
    {
        public ExistingRecipeDto(string name,
                                 int numberOfDays,
                                 IEnumerable<ExistingIngredientDto> ingredients,
                                 int recipeId)
        {
            Name = name;
            NumberOfDays = numberOfDays;
            Ingredients = ingredients;
            RecipeId = recipeId;
        }

        public string Name { get; }

        public int NumberOfDays { get; }

        public IEnumerable<ExistingIngredientDto> Ingredients { get; }

        public int RecipeId { get; }
    }
}