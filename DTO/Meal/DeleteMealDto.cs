namespace DTO.Meal
{
    public class DeleteMealDto
    {
        public DeleteMealDto(int mealId)
        {
            MealId = mealId;
        }

        public int MealId { get;  }
    }
}