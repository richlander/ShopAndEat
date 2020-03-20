using System;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Meal : IMeal
    {
        public Meal(in DateTime day, MealType mealType, IRecipe recipe)
        {
            Day = day;
            MealType = mealType;
            Recipe = recipe;
        }

        public DateTime Day { get; }

        public MealType MealType { get; }

        public IRecipe Recipe { get; }
    }
}