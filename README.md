#  Stock Management System

ASP.NET Core MVC ile geliştirilmiş bu proje, küçük ve orta ölçekli işletmelerin stok, cari kart ve satın alma süreçlerini pratik bir şekilde yönetmesini sağlar.

---

##  Features

- **Cari Kart Yönetimi**  
  - Müşteri veya tedarikçi bilgilerini oluşturma & listeleme
<img width="1558" alt="image" src="https://github.com/user-attachments/assets/fe0b8bb8-6add-4a4a-afb3-1868b9ed9ecd" />

- **Stok Kart Yönetimi**  
  - Ürün adı, açıklaması, KDV oranı, alış/satış fiyatı ve birim türü tanımlama
<img width="1531" alt="image" src="https://github.com/user-attachments/assets/c24fef78-affc-4438-a31e-e2184d41b3c7" />

- **Satın Alma Sözleşmesi**  
  - Bir cari kart ve bir veya daha fazla stok kartı ile sözleşme oluşturma  
  - Satın alma sonrası **otomatik e-posta bildirimi** (MailKit + Ethereal)
<img width="1539" alt="image" src="https://github.com/user-attachments/assets/0600c69f-8207-4a18-aea1-d84e0c5193a8" />


---

E-Posta Gönderimi & Ethereal Kullanımı
Bu projede, satın alma sözleşmesi oluşturulduktan sonra otomatik olarak e-posta bildirimi gönderilmektedir. Geliştirme ve test sürecinde gerçek e-posta adresleri yerine Ethereal adlı sahte bir SMTP sunucusu kullanılmıştır.

SMTP Host: smtp.ethereal.email

SMTP Port: 587

Username: duncan.rowe1@ethereal.email

Password: KGdSJv9N8B581TzQcU



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




