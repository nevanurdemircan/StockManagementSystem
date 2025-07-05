using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models.Dtos;
using StockManagementSystem.Service.Abstarcts;
using StockManagementSystem.Service.Abstracts;

namespace StockManagementSystem.Controllers;

public class PurchaseContractController : Controller
{
    private readonly IPurchaseContractService _purchaseContractService;
    private readonly IStockCardService _stockCardService;
    private readonly ICurrentCardService _currentCardService;

    public PurchaseContractController(IPurchaseContractService purchaseContractService, IStockCardService stockCardService, ICurrentCardService currentCardService)
    {
        _purchaseContractService = purchaseContractService;
        _stockCardService = stockCardService;
        _currentCardService = currentCardService;
    }

    public IActionResult Index()

    {
        var result = new PurchaseContractIndexViewDto
        {
            PurchaseContracts = _purchaseContractService.GetAll(),
            StockCards = _stockCardService.GetAll() ,
            CurrentCards = _currentCardService.GetAll()

        };
        return View(result);
    }
    [HttpPost]
    public IActionResult Save([FromBody] PurchaseContractSaveDto request)
    {
        _purchaseContractService.Save(request);
        return RedirectToAction("Index");
    }
}