using System.Text.Json;
using AutoMapper;
using back_todolistauth_aspnet.src.Infrastructure.Configurations.Mappers;
using Microsoft.AspNetCore.Mvc;

class UpdateItemListUsecase(IItensListRepository repository, IMapper mapper)
{
    private readonly IItensListRepository repository = repository;
    private readonly IMapper mapper = mapper;

    public async Task<ItemListEntity?> UpdateItemList(ItemListEntity itemListEntity, ItensListsResquestDTO dto)
    {
        try
        {
            bool isDtoValid = IsDtoValid(dto);

            if (!isDtoValid) return null;

            bool isPropsEquals = VerifyPropsEquals(itemListEntity, dto);

            if (isPropsEquals) throw new PropertiesEqualsException("No properties have changed because they are the same equals");

            mapper.Map(dto, itemListEntity);

            return await repository.UpdateItemList(itemListEntity);
        }
        catch (PropertiesEqualsException)
        {

            throw;
        }
    }

    private static bool VerifyPropsEquals(ItemListEntity itemListEntity, ItensListsResquestDTO dto)
    {
        if (itemListEntity.Title == dto.Title || itemListEntity.Description == dto.Description) return true;

        return false;
    }

    private static bool IsDtoValid(ItensListsResquestDTO dto)
    {
        if (dto.Title == null || dto.Description == null) return false;

        return true;
    }
}