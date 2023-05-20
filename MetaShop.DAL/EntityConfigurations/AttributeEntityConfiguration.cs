using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EntityAttribute = MetaShop.DAL.Entities.Attribute;

namespace MetaShop.DAL.EntityConfigurations
{
    internal class AttributeEntityConfiguration : IEntityTypeConfiguration<EntityAttribute>
    {
        public void Configure(EntityTypeBuilder<EntityAttribute> builder)
        {
            builder.ToTable("Attribute");
            builder.HasKey(x => x.Id);
        }
    }
}
