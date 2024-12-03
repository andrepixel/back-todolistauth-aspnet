class CreateItemListUsecase
{
    private readonly IItensListRepository repository;

    public CreateItemListUsecase(IItensListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<ItemListEntity?> CreateItemList(ListEntity listEntity)
    {
        return await repository.CreateItemList(new ItemListEntity(name: "Nova Tarefa", description: "Hello World!", list: listEntity));
    }
}