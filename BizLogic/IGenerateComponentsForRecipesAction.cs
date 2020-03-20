using System.Collections.Generic;
using DataLayer.Core;

namespace BizLogic
{
    public interface IGenerateComponentsForRecipesAction
    {
        IEnumerable<(IIngredient,int)> GenerateComponents(IEnumerable<IRecipe> recipes);
    }
}