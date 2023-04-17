using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class EnumMethods
    {
        public enum GetCouponType
        {
            percent = 1,

            [Description("Fixed Amount")]
            fixedAmount = 2
        }
        public enum GetCouponStatus
        {
            active = 1,
            expired = 2,
            disabled = 3
        }
    }
}
