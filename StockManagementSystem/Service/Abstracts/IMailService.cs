using StockManagementSystem.Models;

namespace StockManagementSystem.Service.Abstracts;

public interface IMailService
{
    void SendPurchaseMail(PurchaseContract purchaseContract);
}