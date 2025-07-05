using System.Runtime.InteropServices.JavaScript;
using AutoMapper;
using StockManagementSystem.Context;
using StockManagementSystem.Mapping;
using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;
using StockManagementSystem.Service.Abstracts;

namespace StockManagementSystem.Service.Concretes;

public class CurrentCardService : ICurrentCardService
{
    private readonly BaseDbContext _context;
    private readonly IMapper _mapper;


    
    public CurrentCardService(BaseDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public List<CurrentCardGetAllDto> GetAll()
    {
       List<CurrentCard> currentCards = _context.CurrentCards.ToList();
       return _mapper.Map<List<CurrentCardGetAllDto>>(currentCards);
    }

    public CurrentCard GetById(int id)
    {
        return _context.CurrentCards.Find(id);
    }

    public void Save(CurrentCardSaveDto currentCardSaveDto)
    {
        var utcNow = DateTime.UtcNow;
        var currentCard = _mapper.Map<CurrentCard>(currentCardSaveDto);
        currentCard.CreatedDate = utcNow;
        currentCard.UpdatedDate = utcNow;
        _context.CurrentCards.Add(currentCard);
        _context.SaveChanges();
    }

    public bool Delete(int id)
    {
        var current = _context.CurrentCards.Find(id);
        if (current == null)
            return false;

        _context.CurrentCards.Remove(current);
        _context.SaveChanges();
        return true;    
    }

    public void Update(CurrentCardUpdateDto currentCardUpdateDto)
    {
        var currentCard = _context.CurrentCards.FirstOrDefault(u => u.Id == currentCardUpdateDto.Id);

        _mapper.Map(currentCardUpdateDto, currentCard);
        _context.SaveChanges();
    }

    public void MarkAsEnabled(int id)
    {
        throw new NotImplementedException();
    }

    public void MarkAsDisabled(int id)
    {
        throw new NotImplementedException();
    }
}