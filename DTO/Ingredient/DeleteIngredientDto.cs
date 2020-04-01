namespace DTO.Ingredient
{
    public class DeleteIngredientDto
    {
        public DeleteIngredientDto(int ingredientId)
        {
            IngredientId = ingredientId;
        }

        public int IngredientId { get; }
    }
}