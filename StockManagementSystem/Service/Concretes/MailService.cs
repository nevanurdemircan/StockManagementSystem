using MimeKit;
using StockManagementSystem.Models;
using StockManagementSystem.Service.Abstracts;

namespace StockManagementSystem.Service.Concretes;

public class MailService : IMailService
{
    public void SendPurchaseMail(PurchaseContract purchaseContract)
    {
        var message = new MimeMessage();
        message.From.Add(MailboxAddress.Parse("nevanurdemircan@gmail.com"));
        message.To.Add(MailboxAddress.Parse(purchaseContract.CurrentCard.Mail));
        message.Subject = "Satın Alma Bilgisi";

        var bodyText = $"Merhaba {purchaseContract.CurrentCard.Name + " " + purchaseContract.CurrentCard.Surname},\n\nAşağıdaki ürün(leri) satın aldınız:\n\n";

        foreach (var item in purchaseContract.PurchaseContractStockCards)
        {
            bodyText += $"  Ürün Kodu: {item.StockCard.Code}\n";
            bodyText += $"  Adet: {item.Quantity}\n";
            bodyText += $"  Birim: {item.UnitType}\n\n";
        }

        bodyText += "Teşekkür ederiz!";

        message.Body = new TextPart("plain")
        {
            Text = bodyText
        };


        using var smtp = new MailKit.Net.Smtp.SmtpClient(); 
        smtp.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
        smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
        smtp.Authenticate("duncan.rowe1@ethereal.email", "KGdSJv9N8B581TzQcU");
        smtp.Send(message);
        smtp.Disconnect(true);
    }

}

