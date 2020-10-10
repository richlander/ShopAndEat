using System.ComponentModel.DataAnnotations;

namespace ShopAndEat.Models
{
    public class RecipeModel2
    {
        public RecipeModel2()
        {
            // TODO mu88: Make this smarter
            var numberOfIngredients = 30;
            IngredientQuantities = new double[numberOfIngredients];
            IngredientUnitIds = new int[numberOfIngredients];
            IngredientArticleNames = new string[numberOfIngredients];
            IngredientArticleGroupIds = new int[numberOfIngredients];
            IngredientArticleIsInventories = new bool[numberOfIngredients];
        }

        [Required] public string Name { get; set; }

        [Required] public int NumberOfDays { get; set; }

        [Required] public double[] IngredientQuantities { get; set; }

        [Required] public int[] IngredientUnitIds { get; set; }

        [Required] public string[] IngredientArticleNames { get; set; }

        [Required] public int[] IngredientArticleGroupIds { get; set; }

        [Required] public bool[] IngredientArticleIsInventories { get; set; }

        public void DeleteIngredient(int idToDelete)
        {
            if (idToDelete < 0)
            {
                return;
            }

            IngredientQuantities[idToDelete] = default;
            IngredientUnitIds[idToDelete] = default;
            IngredientArticleNames[idToDelete] = default;
            IngredientArticleGroupIds[idToDelete] = default;
            IngredientArticleIsInventories[idToDelete] = default;
        }
    }
}