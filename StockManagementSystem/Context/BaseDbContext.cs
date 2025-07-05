using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Models;

namespace StockManagementSystem.Context;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
    {
    }

    public DbSet<StockTransaction> StockTransactions { get; set; }
    public DbSet<CurrentCard> CurrentCards { get; set; }
    public DbSet<PurchaseContractStockCard> PurchaseContractStockCards { get; set; }
    public DbSet<PurchaseContract> PurchaseContracts { get; set; }
    public DbSet<StockCard> StockCards { get; set; }
}