using System.Collections.Generic;

namespace DataLayer.Core
{
    public interface IRecipe
    {
        string Name { get; }

        int NumberOfDays { get; }

        IReadOnlyCollection<(IIngredient, int)> Components { get; }

        void AddComponent((IIngredient, int) component);

        void DeleteComponent((IIngredient, int) component);
    }
}