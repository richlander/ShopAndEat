using System.Collections.Generic;

namespace DataLayer.Core
{
    public interface IRecipe
    {
        string Name { get; }

        int NumberOfDays { get; }

        IReadOnlyCollection<IIngredient> Ingredients { get; }

        void AddIngredient(IIngredient ingredient);

        void DeleteIngredient(IIngredient ingredient);
    }
}