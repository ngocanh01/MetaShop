using MetaShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetaShop.DAL.EntityConfigurations
{
    internal class CouponEntityConfiguration : BaseEntityTypeConfiguration<Coupon>
    {
        public override void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.ToTable("Coupon");

            builder.HasKey(x => x.Id);

        }
    }
}
