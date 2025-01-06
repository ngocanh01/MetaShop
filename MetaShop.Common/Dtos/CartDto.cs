using MetaShop.DAL.Entities;

namespace MetaShop.Common.Dtos
{
    public class CartDto : BaseDto
    {
        public CartDto()
        {
            CartItems = new List<CartItem>();
        }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }

    }
}
