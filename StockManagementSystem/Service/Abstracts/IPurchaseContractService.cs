using StockManagementSystem.Models.Dtos;

namespace StockManagementSystem.Service.Abstarcts;

public interface IPurchaseContractService
{
    List<PurchaseContractGetAllDto> GetAll();
    void Save(PurchaseContractSaveDto purchaseContractSaveDto);

}