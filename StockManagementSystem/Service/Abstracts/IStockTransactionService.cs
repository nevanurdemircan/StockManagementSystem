using StockManagementSystem.Models;

namespace StockManagementSystem.Service.Abstarcts;

public interface IStockTransactionService
{
    List<StockTransaction> GetAll();

}