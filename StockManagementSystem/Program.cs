using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Context;
using StockManagementSystem.Mapping;
using StockManagementSystem.Service.Abstarcts;
using StockManagementSystem.Service.Abstracts;
using StockManagementSystem.Service.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BaseDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ICurrentCardService, CurrentCardService>();
builder.Services.AddScoped<IStockTransactionService, StockTransactionService>();
builder.Services.AddScoped<IPurchaseContractService, PurchaseContractService>();
builder.Services.AddScoped<IMailService, MailService>();
builder.Services.AddScoped<IStockCardService, StockCardService>();
builder.Services.AddAutoMapper(typeof(CurrentCardMapper));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();