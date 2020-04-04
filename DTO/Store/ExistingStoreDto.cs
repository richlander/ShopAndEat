namespace DTO.Store
{
    public class ExistingStoreDto
    {
        public ExistingStoreDto(int storeId)
        {
            StoreId = storeId;
        }

        public int StoreId { get; }
    }
}