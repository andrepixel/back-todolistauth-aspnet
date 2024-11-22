interface IItemListRepository
{
    public Task<List<ItemListEntity>?> GetAllItens();
    public Task<ItemListEntity?> GetItemById(Guid id);
    public Task<ItemListEntity?> CreateItem(ItemListEntity itemListEntity);
    public Task<ItemListEntity?> UpdateItem(ItemListEntity itemListEntity);
    public Task<ItemListEntity?> DeleteItemById(ItemListEntity itemListEntity);
}