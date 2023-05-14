using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    public class ProductInformation
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
