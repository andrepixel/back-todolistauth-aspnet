class DeleteListsUsecase
{
    private readonly IItensListRepository repository;

    public DeleteListsUsecase(IItensListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<ListEntity?> DeleteListById(ListEntity listEntity)
    {
        return await repository.DeleteListById(listEntity);   
    }
}