using MetaShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
