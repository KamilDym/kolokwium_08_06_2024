using Microsoft.EntityFrameworkCore;
using WebApplication1.EfConifguration;
using WebApplication1.Models;

namespace WebApplication1.Context;

public class AppDbContext : DbContext
{

    public DbSet<Client> Client { get; set; }
    public DbSet<Sale> Sale { get; set; }
    public DbSet<Subscription> Subscription { get; set; }
    public DbSet<Discount> Discount { get; set; }
    public DbSet<Payment> Payment { get; set; }
    
    public AppDbContext() { }

    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.ApplyConfiguration(new ClientEFConfiguration());
        modelBuilder.ApplyConfiguration(new SaleEFConfiguration());
        modelBuilder.ApplyConfiguration(new SubscriptionEFConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountEFConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentEFConfiguration());

    }
}