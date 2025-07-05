namespace StockManagementSystem.Models;

public class PurchaseContractStockCard
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public bool Enabled { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public PurchaseContract PurchaseContract { get; set; }
    public UnitType UnitType { get; set; }
    public StockCard StockCard { get; set; }
}
    