using MetaShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Common.Dtos
{
    public class ProductInformationDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AssetId { get; set; }
        public int AttributeId { get; set; }
        public string? Value { get; set; }
        public virtual Product Product { get; set; }
        public virtual Asset Assets { get; set; }
        public virtual Attribute Attributes { get; set; }
    }
}
