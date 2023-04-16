using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class Coupon : BaseEntity
    {
        public string CouponCode { get; set; }
        public GetCouponType CouponType { get; set; }
        public decimal CouponValue { get; set; }
        public DateTime CouponStartDate { get; set; }
        public DateTime CouponEndDate { get; set; }
        public decimal CouponMinSpend { get; set; }
        public decimal CouponMaxSpend { get; set; }
        public int CouponUserPerCustomer { get; set; }
        public int CouponUserPerCoupon { get; set; }
        public GetCouponStatus CouponStatus { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
    public enum GetCouponType
    {
        percent,
        fixedAmount
    }
    public enum GetCouponStatus
    {
        active,
        expired,
        disabled
    }
}
