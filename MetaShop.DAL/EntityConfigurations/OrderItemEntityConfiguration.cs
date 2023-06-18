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
    internal class OrderItemEntityConfiguration : BaseEntityTypeConfiguration<OrderItem>
    {
        public override void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem");

            builder.HasKey(x => x.Id);

        }
    }
}
