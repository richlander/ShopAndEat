using System;
using JetBrains.Annotations;

namespace DataLayer.EfClasses;

public class Meal
{
    public Meal(DateTime day, MealType mealType, Recipe recipe)
    {
        Day = day;
        MealType = mealType;
        Recipe = recipe;
    }

    public Meal()
    {
    }

    public DateTime Day { get; [UsedImplicitly] private set; }

    public virtual MealType MealType { get; [UsedImplicitly] private set; }

    public virtual Recipe Recipe { get; [UsedImplicitly] private set; }

    public int MealId { get; [UsedImplicitly] private set; }
        
    public bool HasBeenShopped { get; set; }
}