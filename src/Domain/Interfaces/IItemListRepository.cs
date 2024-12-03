interface IItensListRepository
{
    public Task<List<ItemListEntity>?> GetAllItensList();
    public Task<ItemListEntity?> FindItemListById(Guid id);
    public Task<ItemListEntity?> CreateItemList(ItemListEntity itemListEntity);
    public Task<ItemListEntity?> UpdateItemList(ItemListEntity itemListEntity);
    public Task<ItemListEntity?> DeleteItemList(ItemListEntity itemListEntity);
}