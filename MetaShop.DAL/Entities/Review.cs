namespace MetaShop.DAL.Entities
{
    public class Review : BaseEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int? Rating { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsApproved { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
