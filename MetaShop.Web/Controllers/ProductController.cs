using MetaShop.Business.Interfaces;
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
            ViewBag.categories = await _categoryService.GetAllAsync();
            ViewBag.products = await _productService.GetAllAsync();
            return View();
        }
    }
}
