using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Enums
{
    public class CouponType
    {
        public enum GetCouponType
        {
            Percent = 1,

            [Description("Fixed Amount")]
            FixedAmount = 2
        }
    }
}
