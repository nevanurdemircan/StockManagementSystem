namespace StockManagementSystem.Models.Dtos;

public class StockCardSaveDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double VatRate { get; set; }
    public double PurchasePrice { get; set; }
    public double SalePrice { get; set; }
    public bool Enabled { get; set; }
    public UnitType UnitType { get; set; }
}