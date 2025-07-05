using AutoMapper;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;

namespace StockManagementSystem.Mapping;

public class PurchaseContractMapper : Profile
{
    public PurchaseContractMapper()
    {
        CreateMap<PurchaseContract, PurchaseContractGetAllDto>();
        CreateMap<PurchaseContractGetAllDto, PurchaseContract>();
        CreateMap<PurchaseContractSaveDto, PurchaseContract>();

    }
}