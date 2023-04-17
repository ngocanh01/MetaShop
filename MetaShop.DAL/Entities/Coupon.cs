using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class Coupon : BaseEntity
    {
        public string CouponCode { get; set; }
        public EnumMethods.GetCouponType CouponType { get; set; }
        public decimal CouponValue { get; set; }
        public DateTime CouponStartDate { get; set; }
        public DateTime CouponEndDate { get; set; }
        public decimal CouponMinSpend { get; set; }
        public decimal CouponMaxSpend { get; set; }
        public int CouponUserPerCustomer { get; set; }
        public int CouponUserPerCoupon { get; set; }
        public EnumMethods.GetCouponStatus CouponStatus { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
    
}
