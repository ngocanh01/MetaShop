using MetaShop.Common;
using MetaShop.Common.Dtos;
using MetaShop.Common.Dtos.Product;

namespace MetaShop.Web.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<CategoryDto> Categories { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        public PagedResponseModel<ProductDto> Paged { get; set; }
    }
}
