
class ItensListApplicationService
{
    private readonly GetItensListUsecase getItensListUsecase;
    private readonly CreateItemListUsecase createItemListUsecase;
    private readonly FindItemListUsecase findItemListUsecase;
    private readonly UpdateItemListUsecase updateItemListUsecase;
    private readonly DeleteItemListUsecase deleteItemListUsecase;
    private readonly FindListUsecase findListUsecase;

    public async Task<List<ItemListEntity>?> GetItensList(Guid listId)
    {
        ListEntity? listEntity = await findListUsecase.FindListById(listId);

        if (listEntity == null) return null;
        if (listEntity.Itens == null) return null;

        return listEntity.Itens;
    }

    public async Task<ItemListEntity?> CreateItemList(Guid listId)
    {
        ListEntity? listEntity = await findListUsecase.FindListById(listId);

        if (listEntity == null) return null;

        return await createItemListUsecase.CreateItemList(listEntity);
    }

    public async Task<ItemListEntity?> UpdateItemList(Guid listId, Guid itemId, ItensListsResquestDTO dto)
    {
        ListEntity? listDB = await findListUsecase.FindListById(listId);

        if (listDB == null) return null;

        var itemListDB = await findItemListUsecase.FindItemListById(itemId);

        if (itemListDB == null) return null;

        return await updateItemListUsecase.UpdateItemList(itemListDB, dto);
    }

    public async Task<ItemListEntity?> DeleteItemListById(Guid listId, Guid itemId)
    {
        ListEntity? listEntity = await findListUsecase.FindListById(listId);

        if (listEntity == null) return null;

        return await deleteItemListUsecase.DeleteItemList(itemId, listEntity);
    }
}