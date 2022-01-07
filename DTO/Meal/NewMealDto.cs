using System;
using DTO.MealType;
using DTO.Recipe;

namespace DTO.Meal;

public class NewMealDto
{
    public NewMealDto(DateTime day, ExistingMealTypeDto mealType, ExistingRecipeDto recipe)
    {
        Day = day;
        MealType = mealType;
        Recipe = recipe;
    }

    public DateTime Day { get; }

    public ExistingMealTypeDto MealType { get; }

    public ExistingRecipeDto Recipe { get; }
}