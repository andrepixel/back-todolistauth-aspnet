class GetItensListUsecase
{
    private readonly IItensListRepository repository;

    public GetItensListUsecase(IItensListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<List<ItemListEntity>?> GetAllItensList()
    {
        return await repository.GetAllItensList();
    }
}