public class CreateListsUsecase(IListRepository repository)
{
    private readonly IListRepository repository = repository;

    public async Task<ListEntity?> CreateList()
    {
        return await repository.CreateList(new ListEntity(name: "Nova Tarefa", null));
    }
}