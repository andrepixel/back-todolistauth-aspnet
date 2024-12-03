
class ListApplicationService
{
    private readonly GetListsUsecase getListsUsecase;
    private readonly CreateListsUsecase createListsUsecase;
    private readonly FindListUsecase findListsUsecase;
    private readonly UpdateListsUsecase updateListsUsecase;
    private readonly DeleteListsUsecase deleteListsUsecase;

    public ListApplicationService(GetListsUsecase getListsUsecase, CreateListsUsecase createListsUsecase, FindListUsecase findListsUsecase, UpdateListsUsecase updateListsUsecase, DeleteListsUsecase deleteListsUsecase)
    {
        this.getListsUsecase = getListsUsecase;
        this.createListsUsecase = createListsUsecase;
        this.findListsUsecase = findListsUsecase;
        this.updateListsUsecase = updateListsUsecase;
        this.deleteListsUsecase = deleteListsUsecase;
    }

    public async Task<List<ListEntity>?> GetLists()
    {
        return await getListsUsecase.GetAllLists();
    }

    public async Task<ListEntity?> CreateList()
    {
        return await createListsUsecase.CreateList();
    }

    public async Task<ListEntity?> UpdateList(Guid id, ListsResquestDTO json)
    {
        var entityDB = await findListsUsecase.FindListById(id);

        if (entityDB == null) return null;

        return await updateListsUsecase.UpdateList(entityDB, json);
    }

    public async Task<ListEntity?> DeleteListById(Guid id)
    {
        var listEntity = await findListsUsecase.FindListById(id);

        if (listEntity == null) return null;

        return await deleteListsUsecase.DeleteListById(listEntity);
    }
}