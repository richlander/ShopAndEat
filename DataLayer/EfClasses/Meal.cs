using System;

namespace DataLayer.EfClasses
{
    public class Meal
    {
        public Meal(in DateTime day, MealType mealType, Recipe recipe)
        {
            Day = day;
            MealType = mealType;
            Recipe = recipe;
        }

        public DateTime Day { get; }

        public MealType MealType { get; }

        public Recipe Recipe { get; }
    }
}