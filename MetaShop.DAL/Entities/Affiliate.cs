using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class Affiliate 
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Code { get; set; }
        public float Commission { get; set; }
        public float Balance { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate {  get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
