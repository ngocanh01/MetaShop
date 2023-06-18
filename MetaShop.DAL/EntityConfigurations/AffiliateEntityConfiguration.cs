using MetaShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetaShop.DAL.EntityConfigurations
{
    internal class AffiliateEntityConfiguration : IEntityTypeConfiguration<Affiliate>
    {
        public void Configure(EntityTypeBuilder<Affiliate> builder)
        {
            builder.ToTable("Affiliate");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Customer).WithMany(x => x.Affiliates).HasForeignKey(x => x.CustomerId);
  
        }
    }
}
