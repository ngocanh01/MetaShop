using MetaShop.Business.Interfaces;
using PagedList;
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
        [Route("pagination")]
        public async Task<IActionResult> Pagination(int page)
        {
            var model = await _productService.PagedQueryAsync(page, 9);
            return PartialView("_ProductsPagination", model);
        }

    }
}
