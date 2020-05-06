namespace DTO.MealType
{
    public class ExistingMealTypeDto
    {
        public ExistingMealTypeDto(string name, int mealTypeId)
        {
            Name = name;
            MealTypeId = mealTypeId;
        }

        public string Name { get; }

        public int MealTypeId { get; }
    }
}