namespace DTO.Unit
{
    public class NewUnitDto
    {
        public NewUnitDto(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}