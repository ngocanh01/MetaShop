using MetaShop.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
