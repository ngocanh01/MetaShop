using MetaShop.DAL.Entities;

namespace MetaShop.Common.Dtos
{
    public class ProductInformationDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AssetId { get; set; }
        public int AttributeId { get; set; }
        public string? Value { get; set; }
        public virtual DAL.Entities.Product Product { get; set; }
        public virtual Asset Assets { get; set; }
        public virtual DAL.Entities.Attribute Attributes { get; set; }
    }
}
