using MetaShop.Business.Interfaces;
using MetaShop.Common.Dtos.Product;
using MetaShop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MetaShop.Web.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;

        public ProductController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var listProduct = await _productService.PagedQueryAsync(1, 10);
            var model = new ProductViewModel
            {
                Categories = await _categoryService.GetAllAsync(),
                Products = await _productService.GetAllAsync(),
                Paged = await _productService.PagedQueryAsync(1, 9)
            };
            return View(model);
        }
    }
}
