using System.ComponentModel;

namespace MetaShop.DAL.Enums
{
    public enum CouponType
    {
        Percent = 1,

        [Description("Fixed Amount")]
        FixedAmount = 2
    }
}
