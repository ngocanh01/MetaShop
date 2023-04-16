using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class Review
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int? Rating { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsApproved { get; set; }
        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }

    }
}
