using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class ProductAsset
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AssetId { get; set; }
        public string Type { get; set; }
        public virtual Product Product { get; set; }
        public virtual Assets Assets { get; set; }

    }
}
