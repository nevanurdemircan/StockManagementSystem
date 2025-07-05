namespace StockManagementSystem.Models.Dtos;

public class PurchaseContractIndexViewDto
{
    public IEnumerable<PurchaseContractGetAllDto> PurchaseContracts { get; set; }
    public IEnumerable<StockCardGetAllDto> StockCards { get; set; } 
    public IEnumerable<CurrentCardGetAllDto> CurrentCards { get; set; }

}