class CreateListsUsecase
{
    private readonly IItensListRepository repository;

    public CreateListsUsecase(IItensListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<ListEntity?> CreateList()
    {
        return await repository.CreateList(new ItemListEntity(name: "Nova Tarefa", null));
    }
}