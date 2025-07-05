namespace StockManagementSystem.Models.Dtos;

public class PurchaseContractStockCardSaveDto
{
    public int Quantity { get; set; }
    public UnitType Unit { get; set; }
    public int StockCardId { get; set; }
}