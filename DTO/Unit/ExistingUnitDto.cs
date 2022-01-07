namespace DTO.Unit;

public class ExistingUnitDto
{
    public ExistingUnitDto(int unitId, string name)
    {
        UnitId = unitId;
        Name = name;
    }

    public int UnitId { get; }

    public string Name { get; }
}