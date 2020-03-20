using System;

namespace DataLayer.Core
{
    public interface IMeal
    {
        DateTime Day { get; }

        IMealType MealType { get; }

        IRecipe Recipe { get; }
    }
}