namespace StockManagementSystem.Models.Dtos;

public class CurrentCardSaveDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public CurrentType CurrentType { get; set; }
    public bool Enabled { get; set; }
}