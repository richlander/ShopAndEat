using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Core;

namespace BizLogic.Concrete
{
    public class GenerateComponentsForRecipesAction : IGenerateComponentsForRecipesAction
    {
        public IEnumerable<(IIngredient, int)> GenerateComponents(IEnumerable<IRecipe> recipes)
        {
            return recipes.Select(recipe => recipe.Components)
                          .SelectMany(components => components)
                          .GroupBy(x => x.Item1)
                          .Select(y => ValueTuple.Create(y.Key, y.Sum(z => z.Item2)));
        }
    }
}