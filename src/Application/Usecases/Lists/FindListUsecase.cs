class FindListUsecase(IListRepository repository)
{
    private readonly IListRepository repository = repository;

    public async Task<ListEntity?> FindListById(Guid id)
    {
        return await repository.FindListById(id);
    }
}