using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
            ProductAssets = new List<ProductAsset>();
            Reviews = new List<Review>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int Quantity { get; set; }
        public int? Sold { get; set; }
        public bool Status { get; set; }
        public bool Featured { get; set; }
        public DateTime? DeletedDate { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductAsset> ProductAssets { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        
    }
}
