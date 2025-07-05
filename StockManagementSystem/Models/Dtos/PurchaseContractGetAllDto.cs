namespace StockManagementSystem.Models.Dtos;

public class PurchaseContractGetAllDto
{
    public int Id { get; set; }
    public string DocumentCode { get; set; }
    public CurrentCard CurrentCard { get; set; }
    public List<PurchaseContractStockCard> PurchaseContractStockCards { get; set; }
}