using System.Collections.Generic;
using DTO.Ingredient;

namespace DTO.Recipe;

public class UpdateRecipeDto
{
    public UpdateRecipeDto(string name,
                           int numberOfDays,
                           IEnumerable<NewIngredientDto> ingredients,
                           int recipeId)
    {
        Name = name;
        NumberOfDays = numberOfDays;
        Ingredients = ingredients;
        RecipeId = recipeId;
    }

    public string Name { get; }

    public int NumberOfDays { get; }

    public IEnumerable<NewIngredientDto> Ingredients { get; }

    public int RecipeId { get; }
}