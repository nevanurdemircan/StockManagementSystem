#  Stock Management System

ASP.NET Core MVC ile geliştirilmiş bu proje, küçük ve orta ölçekli işletmelerin stok, cari kart ve satın alma süreçlerini pratik bir şekilde yönetmesini sağlar.

---

##  Features

- **Cari Kart Yönetimi**  
  - Müşteri veya tedarikçi bilgilerini oluşturma & listeleme  
- **Stok Kart Yönetimi**  
  - Ürün adı, açıklaması, KDV oranı, alış/satış fiyatı ve birim türü tanımlama  
- **Satın Alma Sözleşmesi**  
  - Bir cari kart ve bir veya daha fazla stok kartı ile sözleşme oluşturma  
  - Satın alma sonrası **otomatik e-posta bildirimi** (MailKit + Ethereal)  
- **Enum Dropdown**  
  - Enum değerleri `DisplayAttribute` ile okunaklı seçimler olarak sunuluyor  
- **Katmanlı Mimari**  
  - Controller, Service, DTO, Entity, DbContext  
- **AutoMapper** ile DTO ↔ Entity dönüşümleri sağlanıyor

---

##  Technologies

| Katman        | Teknoloji / Araç               |
|---------------|--------------------------------|
| Web           | ASP.NET Core MVC              |
| ORM           | Entity Framework Core         |
| Mapping       | AutoMapper                    |
| Mail          | MailKit + Ethereal SMTP       |
| Veritabanı     | SQL Server                   |
| Dil           | C#                            |

---




