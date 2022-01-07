using System.Collections.Generic;
using DTO.Ingredient;

namespace DTO.Recipe;

public class NewRecipeDto
{
    public NewRecipeDto(string name, in int numberOfDays, IEnumerable<NewIngredientDto> ingredients)
    {
        Name = name;
        NumberOfDays = numberOfDays;
        Ingredients = ingredients;
    }

    public string Name { get; }

    public int NumberOfDays { get; }

    public IEnumerable<NewIngredientDto> Ingredients { get; }
}