using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Common.Dtos
{
    public class AssetDto : BaseDto
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
