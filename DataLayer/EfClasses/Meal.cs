using System;
using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class Meal
    {
        public Meal(DateTime day, MealType mealType, Recipe recipe)
        {
            Day = day;
            MealType = mealType;
            Recipe = recipe;
        }

        [UsedImplicitly]
        private Meal()
        {
        }

        public DateTime Day { get; }

        public MealType MealType { get; }

        public Recipe Recipe { get; }

        public int MealId { get; [UsedImplicitly] private set; }
    }
}