namespace DTO.Unit
{
    public class DeleteUnitDto
    {
        public DeleteUnitDto(int unitId)
        {
            UnitId = unitId;
        }

        public int UnitId { get; }
    }
}