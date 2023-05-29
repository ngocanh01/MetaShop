using MetaShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
