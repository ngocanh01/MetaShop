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
    internal class CartEntityConfiguration : BaseEntityTypeConfiguration<Cart>
    {
        public override void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Cart");

            builder.HasKey(x => x.Id);

        }
    }
}
