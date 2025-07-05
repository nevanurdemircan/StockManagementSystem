using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Context;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;
using StockManagementSystem.Service.Abstarcts;
using StockManagementSystem.Service.Abstracts;

namespace StockManagementSystem.Service.Concretes;

public class PurchaseContractService : IPurchaseContractService
{
    private readonly BaseDbContext _context;
    private readonly IMapper _mapper;
    private readonly IMailService _mailService;
    private readonly ICurrentCardService _currentCardService;

    public PurchaseContractService(BaseDbContext context, IMapper mapper, IMailService mailService, ICurrentCardService currentCardService)
    {
        _context = context;
        _mapper = mapper;
        _mailService = mailService;
        _currentCardService = currentCardService;
    }

    public List<PurchaseContractGetAllDto> GetAll()
    {
        List<PurchaseContract> purchaseContracts = _context.PurchaseContracts.Include(i => i.CurrentCard)
            .Include(i => i.PurchaseContractStockCards)
            .ThenInclude(i => i.StockCard)
            .ToList();
        return _mapper.Map<List<PurchaseContractGetAllDto>>(purchaseContracts);
    }

    public void Save(PurchaseContractSaveDto purchaseContractSaveDto)
    {
        var utcNow = DateTime.UtcNow;
        List<PurchaseContractStockCard> purchaseContractStockCards = new List<PurchaseContractStockCard>();

        var currentCard = _currentCardService.GetById(purchaseContractSaveDto.CurrentCardId);
        _context.Attach(currentCard);

        PurchaseContract purchaseContract = new PurchaseContract()
        {
            DocumentCode = purchaseContractSaveDto.DocumentCode,
            CurrentCard = currentCard,
            Enabled = true,
            CreatedDate = utcNow,
            UpdatedDate = utcNow,
            PurchaseContractStockCards = purchaseContractStockCards,
        };
        foreach (var item in purchaseContractSaveDto.PurchaseContractStockCards)
        {
            var stockCard = new StockCard() { Id = item.StockCardId };
            _context.Attach(stockCard);
                
            PurchaseContractStockCard purchaseContractStockCard = new PurchaseContractStockCard()
            {
                Quantity = item.Quantity,
                UnitType = item.Unit,
                StockCard = stockCard,
                Enabled = true,
                PurchaseContract = purchaseContract,
                CreatedDate = utcNow,
                UpdatedDate = utcNow,
            };
            purchaseContractStockCards.Add(purchaseContractStockCard);
        }

        _context.PurchaseContracts.Add(purchaseContract);
        _context.SaveChanges();
        _mailService.SendPurchaseMail(purchaseContract);
    }
}