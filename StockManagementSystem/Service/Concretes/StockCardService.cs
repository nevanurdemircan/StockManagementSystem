using AutoMapper;
using StockManagementSystem.Context;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;
using StockManagementSystem.Service.Abstarcts;

namespace StockManagementSystem.Service.Concretes;

public class StockCardService : IStockCardService
{
    private readonly BaseDbContext _context;
    private readonly IMapper _mapper;


    public StockCardService(BaseDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void Save(StockCardSaveDto stockCardSaveDto)
    {
        var utcNow = DateTime.UtcNow;
        var stockCard = _mapper.Map<StockCard>(stockCardSaveDto);
        stockCard.CreatedDate = utcNow;
        stockCard.UpdatedDate = utcNow;
        _context.StockCards.Add(stockCard);
        _context.SaveChanges();
    }

    public void Update(int id, StockCardUpdateDto stockCardUpdateDto)
    {
        var stockCard = _context.StockCards.Find(id);
        _mapper.Map(stockCardUpdateDto, stockCard);
        _context.SaveChanges();
    }

    public List<StockCardGetAllDto> GetAll()
    {
        List<StockCard> stockCards = _context.StockCards.ToList();
        return _mapper.Map<List<StockCardGetAllDto>>(stockCards);
    }
}