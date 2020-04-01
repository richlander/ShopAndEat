namespace DTO.MealType
{
    public class NewMealTypeDto
    {
        public NewMealTypeDto(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}