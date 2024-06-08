using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

public class SaleEFConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.HasKey(e => e.IdSale);
        builder.Property(e => e.IdSale).ValueGeneratedOnAdd();

        builder.HasOne(e => e.ClientNavogator)
            .WithMany(c => c.Sales)
            .HasForeignKey(e => e.IdClient)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(e => e.SubscriptionNavigator)
            .WithMany(c => c.Sales)
            .HasForeignKey(e => e.IdSubscription)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Property(e => e.CreatedAt).IsRequired();

    }
}