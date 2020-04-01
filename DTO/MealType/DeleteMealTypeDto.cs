namespace DTO.MealType
{
    public class DeleteMealTypeDto
    {
        public DeleteMealTypeDto(int mealTypeId)
        {
            MealTypeId = mealTypeId;
        }

        public int MealTypeId { get; }
    }
}