using MetaShop.DAL.Entities;

namespace MetaShop.Common.Dtos
{
    public class AffiliateDto : BaseDto
    {
        public int CustomerId { get; set; }
        public string Code { get; set; }
        public decimal Commission { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
