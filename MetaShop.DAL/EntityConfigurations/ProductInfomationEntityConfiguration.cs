﻿using MetaShop.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.EntityConfigurations
{
    internal class ProductInformationEntityConfiguration : IEntityTypeConfiguration<ProductInformation>
    {
        public void Configure(EntityTypeBuilder<ProductInformation> builder)
        {
            builder.ToTable("ProductInformation");

            builder.HasKey(x => x.Id);

        }
    }
}
