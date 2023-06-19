using MetaShop.Business.Interfaces;
using MetaShop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MetaShop.Web.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;

        public ContactController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var model = new ContactViewModel
            {
                Categories = await _categoryService.GetAllAsync(),
                Products = await _productService.GetAllAsync()
            };
            return View(model);
        }
    }
}
