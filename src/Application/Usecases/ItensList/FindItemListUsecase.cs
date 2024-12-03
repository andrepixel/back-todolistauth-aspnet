public class FindItemListUsecase
{
    private readonly IItensListRepository repository;

    public FindItemListUsecase(IItensListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<ItemListEntity?> FindItemListById(Guid id)
    {
        return await repository.FindItemListById(id);
    }
}