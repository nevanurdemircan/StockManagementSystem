namespace StockManagementSystem.Models;

public class PurchaseContract
{
    public int Id { get; set; }
    public string DocumentCode { get; set; }
    public bool Enabled { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public CurrentCard CurrentCard { get; set; }
    public List<PurchaseContractStockCard> PurchaseContractStockCards { get; set; }
}