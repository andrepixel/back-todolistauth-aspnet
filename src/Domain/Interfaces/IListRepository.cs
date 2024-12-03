public interface IListRepository
{
    public Task<List<ListEntity>?> GetAllLists();
    public Task<ListEntity?> FindListById(Guid id);
    public Task<ListEntity?> CreateList(ListEntity listEntity);
    public Task<ListEntity?> UpdateList(ListEntity listEntity);
    public Task<ListEntity?> DeleteListById(ListEntity listEntity);
}