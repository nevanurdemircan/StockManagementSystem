using Microsoft.AspNetCore.Mvc.Rendering;

namespace StockManagementSystem.Models.Dtos;

public class CurrentCardIndexViewDto
{
    public IEnumerable<CurrentCardGetAllDto> CurrentCards { get; set; }
    public IEnumerable<SelectListItem> CurrentTypes { get; set; }
}