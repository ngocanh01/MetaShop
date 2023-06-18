using MetaShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Common.Dtos
{
    public class CartItemDto : BaseDto
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
