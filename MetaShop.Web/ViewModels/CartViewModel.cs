using MetaShop.Common.Dtos;
using MetaShop.Common.Dtos.Product;

namespace MetaShop.Web.ViewModels
{
    public class CartViewModel
    {
        public IEnumerable<CategoryDto> Categories { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
