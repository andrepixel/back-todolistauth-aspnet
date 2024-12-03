using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

class UpdateListsUsecase
{
    private readonly IListRepository repository;

    public UpdateListsUsecase(IListRepository repository)
    {
        this.repository = repository;
    }

    public async Task<ListEntity?> UpdateList(ListEntity listEntity, ListsResquestDTO dto)
    {
        try
        {
            ListEntity? listEntityUpdated = UpdateProps(listEntity, dto);

            if (listEntityUpdated == null) return null;

            return await repository.UpdateList(listEntity);
        }
        catch (PropertiesEqualsException)
        {

            throw;
        }
    }

    private ListEntity? UpdateProps(ListEntity listEntity, ListsResquestDTO dto)
    {
        if (dto.Title == null) return null;

        if (listEntity.Title == dto.Title) throw new PropertiesEqualsException("No properties have changed because they are the same equals");

        if (dto.Title != null) listEntity.Title = dto.Title;

        return listEntity;
    }
}