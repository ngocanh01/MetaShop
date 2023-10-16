namespace MetaShop.DAL.Entities
{
    public class CartItem : BaseEntity
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
