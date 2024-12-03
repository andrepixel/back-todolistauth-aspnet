using System;
using AutoMapper;

namespace back_todolistauth_aspnet.src.Infrastructure.Configurations.Mappers;

public class ItemListMapper : Profile
{
    protected ItemListMapper()
    {
        CreateMap<ItemListEntity, ItensListsResquestDTO>()
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

        CreateMap<ItensListsResquestDTO, ItemListEntity>()
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
    }
}
