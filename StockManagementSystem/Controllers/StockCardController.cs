using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;
using StockManagementSystem.Service.Abstarcts;

namespace StockManagementSystem.Controllers;

public class StockCardController : Controller
{
    private readonly IStockCardService _stockCardService;

    public StockCardController(IStockCardService stockCardService)
    {
        _stockCardService = stockCardService;
    }

    public IActionResult Index()
    {
        var result = _stockCardService.GetAll();
        StockCardIndexViewDto view = new StockCardIndexViewDto()
        {
            StockCards = result,
            UnitTypes = Enum.GetValues(typeof(UnitType))
                .Cast<UnitType>()
                .Select(c => new SelectListItem
                {
                    Value = ((int)c).ToString(),
                    Text = c.GetType()
                        .GetMember(c.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()?.Name ?? c.ToString()
                })
        };
        
        return View(view);
    }

    [HttpPost]
    public IActionResult Save(StockCardSaveDto dto)
    {
        _stockCardService.Save(dto);
        return RedirectToAction("Index");
    }
}