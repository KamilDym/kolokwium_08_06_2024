using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

public class DiscountEFConfiguration: IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.HasKey(e => e.IdDiscount);
        builder.Property(e => e.IdDiscount).ValueGeneratedOnAdd();

        builder.Property(e => e.Value).IsRequired();
        
        builder.HasOne(e => e.SubscriptionNavigator)
            .WithMany(c => c.Discounts)
            .HasForeignKey(e => e.IdSubscription)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Property(e => e.DateFrom).IsRequired();
        builder.Property(e => e.DateTo).IsRequired();
        
    }
}