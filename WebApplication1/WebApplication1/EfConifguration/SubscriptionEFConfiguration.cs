using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.EfConifguration;

public class SubscriptionEFConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.HasKey(e => e.IdSubscription);
        builder.Property(e => e.IdSubscription).ValueGeneratedOnAdd();

        builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
        builder.Property(e => e.RenewalPeriod).IsRequired();
        builder.Property(e => e.EndTime).IsRequired();
        builder.Property(e => e.Price).IsRequired();
    }
}