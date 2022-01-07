namespace DTO.Store;

public class ExistingStoreDto
{
    public ExistingStoreDto(int storeId, string name)
    {
        StoreId = storeId;
        Name = name;
    }

    public int StoreId { get; }

    public string Name { get; }
}