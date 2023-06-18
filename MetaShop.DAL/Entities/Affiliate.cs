using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    public class Affiliate : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Code { get; set; }
        public decimal Commission { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
