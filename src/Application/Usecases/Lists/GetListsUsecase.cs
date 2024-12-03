public class GetListsUsecase
{
    private readonly IListRepository repository;

    public GetListsUsecase(IListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<List<ListEntity>?> GetAllLists()
    {
        return await repository.GetAllLists();
    }
}