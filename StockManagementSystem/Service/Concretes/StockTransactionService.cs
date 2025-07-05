using StockManagementSystem.Context;
using StockManagementSystem.Models;
using StockManagementSystem.Service.Abstarcts;

namespace StockManagementSystem.Service.Concretes;

public class StockTransactionService : IStockTransactionService
{
    private readonly BaseDbContext _context;

    public List<StockTransaction> GetAll()
    {
       return _context.StockTransactions.ToList();
    }
}