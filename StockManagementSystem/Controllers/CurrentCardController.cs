using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;
using StockManagementSystem.Service.Abstracts;

namespace StockManagementSystem.Controllers;

public class CurrentCardController : Controller
{
    private readonly ICurrentCardService _currentCardService;

    public CurrentCardController(ICurrentCardService currentCardService)
    {
        _currentCardService = currentCardService;
    }

    public IActionResult Index()
    {
        var result = _currentCardService.GetAll();
        CurrentCardIndexViewDto view = new CurrentCardIndexViewDto
        {
            CurrentCards = result,
            CurrentTypes = Enum.GetValues(typeof(CurrentType))
                .Cast<CurrentType>()
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
    public IActionResult Save(CurrentCardSaveDto dto)
    {
        _currentCardService.Save(dto);
        return RedirectToAction("Index");
    }
}