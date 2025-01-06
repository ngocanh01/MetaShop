using MetaShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetaShop.DAL.EntityConfigurations
{
    internal class AssetEntityConfiguration : BaseEntityTypeConfiguration<Asset>
    {
        public override void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.ToTable("Asset");

        }
    }
}