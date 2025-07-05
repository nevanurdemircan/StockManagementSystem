namespace StockManagementSystem.Models;

public class StockTransaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Quantity { get; set; }
    public StockTransactionType Type { get; set; }
    public string Description { get; set; }
    public bool Enabled { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public StockCard StockCard { get; set; }
}