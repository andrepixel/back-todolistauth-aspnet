class DeleteListsUsecase(IListRepository repository)
{
    private readonly IListRepository repository = repository;

    public async Task<ListEntity?> DeleteListById(ListEntity listEntity)
    {
        return await repository.DeleteListById(listEntity);   
    }
}