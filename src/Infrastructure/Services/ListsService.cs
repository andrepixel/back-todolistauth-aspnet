
using System.Text.Json;

class ListsService
{
    private readonly IListRepository repository;

    public async Task<List<ListEntity>?> GetLists()
    {
        return await repository.GetAllLists();
    }

    public async Task<ListEntity?> CreateList()
    {
        return await repository.CreateList(new ListEntity(name: "Nova Tarefa", null));
    }

    public async Task<ListEntity?> UpdateList(Guid id, JsonElement json)
    {
        var entityDB = await repository.GetListById(id);

        if (entityDB == null) return null;

        ListEntity updateEntity = MapperJsonToEntity(entityDB, json);

        return await repository.UpdateList(updateEntity);
    }

    private ListEntity MapperJsonToEntity(ListEntity entityDB, JsonElement json)
    {
        foreach (var property in json.EnumerateObject())
        {
            System.Reflection.PropertyInfo? propertyInfo = entityDB.GetType().GetProperty(property.Name);

            if (propertyInfo != null && propertyInfo.CanWrite)
            {
                object? value = Convert.ChangeType(property.Value.GetString(), propertyInfo.PropertyType);

                propertyInfo.SetValue(entityDB, value);

                repository.SetPropertyModified(entityDB, propertyInfo);
            }
        }

        return entityDB;
    }

    public async Task<ListEntity?> DeleteListById(Guid id)
    {
        var listEntity = await repository.GetListById(id);

        if (listEntity == null) return null;

        return await repository.DeleteListById(listEntity);
    }
}