using MetaShop.DAL.Entities;

namespace MetaShop.Common.Dtos
{
    public class ReviewDto : BaseDto
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int? Rating { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsApproved { get; set; }
        public virtual DAL.Entities.Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
