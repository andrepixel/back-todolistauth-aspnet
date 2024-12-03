public class DeleteItemListUsecase
{
    private readonly IItensListRepository repository;

    public DeleteItemListUsecase(IItensListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<ItemListEntity?> DeleteItemList(Guid itemId, ListEntity listEntity)
    {
        if (listEntity.Itens == null) return null;

        foreach (var item in listEntity.Itens)
        {
            if (item.Id == itemId)
            {
                return await repository.DeleteItemList(item);
            };
        }

        return null;
    }
}