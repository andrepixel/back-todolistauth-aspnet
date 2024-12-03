class FindListUsecase
{
    private readonly IListRepository repository;

    public FindListUsecase(IListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<ListEntity?> FindListById(Guid id)
    {
        return await repository.GetListById(id);
    }
}