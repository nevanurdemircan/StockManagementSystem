using AutoMapper;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;

namespace StockManagementSystem.Mapping;

public class StockCardMapper : Profile
{
        public StockCardMapper()
        {
            CreateMap<StockCard, StockCardSaveDto>();
            CreateMap<StockCardSaveDto, StockCard>();
            CreateMap<StockCard, StockCardUpdateDto>();
            CreateMap<StockCardUpdateDto, StockCard>();
            CreateMap<StockCard, StockCardGetAllDto>();
            CreateMap<StockCardGetAllDto, StockCard>();
        }
}