using MetaShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetaShop.DAL.EntityConfigurations
{
    internal class ProductAssetEntityConfiguration : IEntityTypeConfiguration<ProductAsset>
    {
        public void Configure(EntityTypeBuilder<ProductAsset> builder)
        {
            builder.ToTable("ProductAsset");

            builder.HasKey(x => x.Id);
  
        }
    }
}
