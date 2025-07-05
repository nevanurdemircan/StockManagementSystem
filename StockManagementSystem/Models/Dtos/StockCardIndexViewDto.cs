using Microsoft.AspNetCore.Mvc.Rendering;

namespace StockManagementSystem.Models.Dtos;

public class StockCardIndexViewDto
{
    public IEnumerable<StockCardGetAllDto> StockCards { get; set; }

    public IEnumerable<SelectListItem> UnitTypes { get; set; }

}