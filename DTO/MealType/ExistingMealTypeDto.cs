namespace DTO.MealType;

public class ExistingMealTypeDto
{
    public ExistingMealTypeDto(string name, int mealTypeId, int order)
    {
        Name = name;
        MealTypeId = mealTypeId;
        Order = order;
    }

    public string Name { get; }

    public int MealTypeId { get; }

    public int Order { get; }
}