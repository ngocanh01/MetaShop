using MetaShop.DAL.Entities;

namespace MetaShop.Common.Dtos
{
    public class OrderItemDto : BaseDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime? DeletedDate { get; set; }
        public virtual Order Order { get; set; }
        public virtual DAL.Entities.Product Product { get; set; }
    }
}
