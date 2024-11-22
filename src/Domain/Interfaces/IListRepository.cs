using System.Reflection;

interface IListRepository
{
    public Task<List<ListEntity>?> GetAllLists();
    public Task<ListEntity?> GetListById(Guid id);
    public Task<ListEntity?> CreateList(ListEntity listEntity);
    public Task<ListEntity?> UpdateList(ListEntity listEntity);
    public Task<ListEntity?> DeleteListById(ListEntity listEntity);
    void SetPropertyModified(ListEntity entityDB, PropertyInfo propertyInfo);
}