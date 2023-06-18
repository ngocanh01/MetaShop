using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Enums
{
    public enum CouponType
    {
        Percent = 1,

        [Description("Fixed Amount")]
        FixedAmount = 2
    }
}
