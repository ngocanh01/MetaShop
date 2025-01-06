using MetaShop.DAL.Enums;

namespace MetaShop.DAL.Entities
{
    public class Coupon : BaseEntity
    {
        public string CouponCode { get; set; }
        public CouponType CouponType { get; set; }
        public decimal CouponValue { get; set; }
        public DateTime CouponStartDate { get; set; }
        public DateTime CouponEndDate { get; set; }
        public decimal CouponMinSpend { get; set; }
        public decimal CouponMaxSpend { get; set; }
        public int CouponUserPerCustomer { get; set; }
        public int CouponUserPerCoupon { get; set; }
        public CouponStatus CouponStatus { get; set; }
        public DateTime? DeletedDate { get; set; }
    }

}
