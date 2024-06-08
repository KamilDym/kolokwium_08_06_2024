using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.EfConifguration;

public class PaymentEFConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(e => e.IdPayment);
        builder.Property(e => e.IdPayment).ValueGeneratedOnAdd();
        
        builder.Property(e => e.Date).IsRequired();

        builder.HasOne(e => e.SubscriptionNavigator)
            .WithMany(c => c.Payments)
            .HasForeignKey(e => e.IdSubscription)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(e => e.ClientNavigator)
            .WithMany(c => c.Payments)
            .HasForeignKey(e => e.IdClient)
            .OnDelete(DeleteBehavior.Cascade);

    }
}