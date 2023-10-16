namespace MetaShop.DAL.Entities
{
    public class Cart : BaseEntity
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }

    }
}
