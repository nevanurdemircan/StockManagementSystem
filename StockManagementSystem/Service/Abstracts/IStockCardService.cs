using StockManagementSystem.Models.Dtos;

namespace StockManagementSystem.Service.Abstarcts;

public interface IStockCardService
{
    void Save(StockCardSaveDto stockCardSaveDto);
    void Update(int id, StockCardUpdateDto stockCardUpdateDto);
    List<StockCardGetAllDto> GetAll();

}