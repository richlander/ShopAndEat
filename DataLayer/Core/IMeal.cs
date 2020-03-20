using System;

namespace DataLayer.Core
{
    public interface IMeal
    {
        DateTime Day { get; }

        MealType MealType { get; }

        IRecipe Recipe { get; }
    }
}