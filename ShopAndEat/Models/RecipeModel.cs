using System.ComponentModel.DataAnnotations;

namespace ShopAndEat.Models
{
    public class RecipeModel
    {
        public RecipeModel()
        {
            // TODO mu88: Make this smarter
            var numberOfIngredients = 30;
            IngredientQuantities = new double[numberOfIngredients];
            IngredientArticleIds = new int[numberOfIngredients];
            IngredientUnitIds = new int[numberOfIngredients];
        }

        [Required] public string Name { get; set; }

        [Required] public int NumberOfDays { get; set; }

        [Required] public double[] IngredientQuantities { get; set; }

        [Required] public int[] IngredientArticleIds { get; set; }

        [Required] public int[] IngredientUnitIds { get; set; }
    }
}