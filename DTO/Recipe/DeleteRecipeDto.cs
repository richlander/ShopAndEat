namespace DTO.Recipe
{
    public class DeleteRecipeDto
    {
        public DeleteRecipeDto(int recipeId)
        {
            RecipeId = recipeId;
        }

        public int RecipeId { get;  }
    }
}