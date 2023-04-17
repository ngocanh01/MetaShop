using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Enums
{
    public class CouponStatus 
    {
        public enum GetCouponStatus
        {
            Active = 1,
            Expired = 2,
            Disabled = 3
        }
    }
}
