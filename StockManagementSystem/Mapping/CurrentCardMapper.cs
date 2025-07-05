using AutoMapper;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;

namespace StockManagementSystem.Mapping;

public class CurrentCardMapper : Profile
{
    public CurrentCardMapper()
    {
        CreateMap<CurrentCardSaveDto, CurrentCard>();
        CreateMap<CurrentCardUpdateDto, CurrentCard>();
        CreateMap<CurrentCard, CurrentCardGetAllDto>();
    }
}