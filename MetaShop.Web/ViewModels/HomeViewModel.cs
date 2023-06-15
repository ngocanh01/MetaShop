using MetaShop.Common.Dtos;

namespace MetaShop.Web.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<CategoryDto> Categories { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
