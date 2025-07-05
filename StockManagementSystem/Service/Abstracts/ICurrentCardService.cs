using StockManagementSystem.Models;
using StockManagementSystem.Models.Dtos;

namespace StockManagementSystem.Service.Abstracts;

public interface ICurrentCardService
{
    List<CurrentCardGetAllDto> GetAll();
    CurrentCard GetById(int id);
    void Save(CurrentCardSaveDto currentCardSaveDto);
    bool Delete(int id);
    void Update(CurrentCardUpdateDto currentCardUpdateDto);
    void MarkAsEnabled(int id);
    void MarkAsDisabled(int id);
}