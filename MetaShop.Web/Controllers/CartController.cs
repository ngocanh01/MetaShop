using MetaShop.Business.Interfaces;
using MetaShop.Common.Dtos.Product;
using MetaShop.DAL.Entities;
using MetaShop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MetaShop.Web.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;

        public CartController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index(Product product)
        {
            var model = new CartViewModel
            {
                Categories = await _categoryService.GetAllAsync(),
                Products = await _productService.GetAllAsync()
            };
            ViewBag.result = product.Quantity;
            return View(model);
        }

        [HttpPost("addToCart")]
        public async Task<IActionResult> AddToCart(ProductCartInfoDtos product)
        {
            product.Total = product.Quantity * product.Price;
			var model = new CartViewModel
			{
				Categories = await _categoryService.GetAllAsync(),
				Products = await _productService.GetAllAsync(),
                Product = product
			};
			return View( "Index", model);
        }
    }
}
