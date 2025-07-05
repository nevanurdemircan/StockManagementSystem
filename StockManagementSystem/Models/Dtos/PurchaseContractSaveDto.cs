namespace StockManagementSystem.Models.Dtos;

public class PurchaseContractSaveDto
{
    public string DocumentCode { get; set; }
    public int CurrentCardId { get; set; }
    public List<PurchaseContractStockCardSaveDto> PurchaseContractStockCards { get; set; }
}