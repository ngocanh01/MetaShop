using MetaShop.Business.Interfaces;
using MetaShop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MetaShop.Web.Controllers
{
	[Route("cart")]
	public class CartController : Controller
	{
		private readonly ICategoryService _categoryService;
		private readonly IProductService _productService;

		public CartController(ICategoryService categoryService, IProductService productService)
		{
			_categoryService = categoryService;
			_productService = productService;
		}
		[Route("")]
		[Route("index")]
		public async Task<IActionResult> Index(ProductCartInfoDtos product)
		{
			List<ProductCartInfoDtos> products = new List<ProductCartInfoDtos>();
			if (HttpContext.Session.GetString("myCart") != null)
			{
				products = JsonConvert.DeserializeObject<List<ProductCartInfoDtos>>(HttpContext.Session.GetString("myCart"));
			} 
			var model = new CartViewModel
			{
				Categories = await _categoryService.GetAllAsync(),
				Products = await _productService.GetAllAsync(),
				ProductsCart = products
			};

			return View("Index", model);
		}

		[HttpPost("addToCart")]
		public async Task<IActionResult> AddToCart(ProductCartInfoDtos product)
		{
			List<ProductCartInfoDtos> products = new List<ProductCartInfoDtos>();

			product.Total = product.Quantity * product.Price;

			if (HttpContext.Session.GetString("myCart") != null)
			{
				products = JsonConvert.DeserializeObject<List<ProductCartInfoDtos>>(HttpContext.Session.GetString("myCart"));

				var productItem = products.FirstOrDefault(x => x.Id == product.Id);
				if (productItem != null)
				{
					product.Quantity += productItem.Quantity;
					product.Total += productItem.Total;
					products.Remove(productItem);
				}

			}

			products.Add(product);
			HttpContext.Session.SetString("myCart", JsonConvert.SerializeObject(products));

			var model = new CartViewModel
			{
				Categories = await _categoryService.GetAllAsync(),
				Products = await _productService.GetAllAsync(),
				ProductsCart = JsonConvert.DeserializeObject<List<ProductCartInfoDtos>>(HttpContext.Session.GetString("myCart"))
			};

			return View("Index", model);
		}
	}
}
