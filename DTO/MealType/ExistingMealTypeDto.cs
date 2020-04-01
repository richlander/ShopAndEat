namespace DTO.MealType
{
    public class ExistingMealTypeDto
    {
        public ExistingMealTypeDto(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}