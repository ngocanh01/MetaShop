using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class Cart : BaseEntity
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
