using MetaShop.DAL.Entities;

namespace MetaShop.Common.Dtos
{
    public class CartItemDto : BaseDto
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual DAL.Entities.Product Product { get; set; }
        public virtual ICollection<DAL.Entities.Product> Products { get; set; }
    }
}
