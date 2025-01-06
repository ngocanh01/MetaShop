using MetaShop.Business.Interfaces;
using MetaShop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
		public async Task<IActionResult> Index()
		{
			// Retrieve the cart from the session or initialize a new one if it's empty
			var cart = HttpContext.Session.GetString("myCart") != null
				? JsonConvert.DeserializeObject<List<ProductCartInfoDtos>>(HttpContext.Session.GetString("myCart"))
				: new List<ProductCartInfoDtos>();

			// Prepare the view model
			var model = new CartViewModel
			{
				Categories = await _categoryService.GetAllAsync(),
				Products = await _productService.GetAllAsync(),
				ProductsCart = cart,
				CartTotal = cart.Sum(x => x.Total) // Calculate total for the cart
			};

			return View("Index", model);
		}

		[HttpPost("addToCart")]
		public async Task<IActionResult> AddToCart(ProductCartInfoDtos product)
		{
			if (product == null || product.Quantity <= 0)
			{
				ModelState.AddModelError("", "Invalid product or quantity.");
				return RedirectToAction("Index");
			}

			var cart = HttpContext.Session.GetString("myCart") != null
				? JsonConvert.DeserializeObject<List<ProductCartInfoDtos>>(HttpContext.Session.GetString("myCart"))
				: new List<ProductCartInfoDtos>();

			var existingProduct = cart.FirstOrDefault(x => x.Id == product.Id);
			if (existingProduct != null)
			{
				// Update the quantity and total for the existing product
				existingProduct.Quantity += product.Quantity;
				existingProduct.Total = existingProduct.Quantity * existingProduct.Price;
			}
			else
			{
				// Add the new product to the cart
				product.Total = product.Quantity * product.Price;
				cart.Add(product);
			}

			// Update the cart in session
			HttpContext.Session.SetString("myCart", JsonConvert.SerializeObject(cart));

			// Prepare the view model
			var model = new CartViewModel
			{
				Categories = await _categoryService.GetAllAsync(),
				Products = await _productService.GetAllAsync(),
				ProductsCart = cart,
				CartTotal = cart.Sum(x => x.Total)
			};

			return View("Index", model);
		}


		[HttpPost("updateCart")]
		public async Task<IActionResult> UpdateCart(List<ProductCartInfoDtos> updatedCartItems)
		{
			if (updatedCartItems == null || !updatedCartItems.Any())
			{
				ModelState.AddModelError("", "No items in the cart.");
				return RedirectToAction("Index"); // Or return the same view with an error message
			}

			foreach (var item in updatedCartItems)
			{
				if (item.Quantity <= 0)
				{
					updatedCartItems.Remove(item);
					ModelState.AddModelError("", "Quantity must be greater than zero.");
				}
			}

			if (!ModelState.IsValid)
			{
				// Load necessary data for the cart view
				var model = new CartViewModel
				{
					Categories = await _categoryService.GetAllAsync(),
					Products = await _productService.GetAllAsync(),
					ProductsCart = JsonConvert.DeserializeObject<List<ProductCartInfoDtos>>(HttpContext.Session.GetString("myCart")),
					CartTotal = updatedCartItems.Sum(x => x.Price * x.Quantity)
				};

				return View("Index", model);
			}

			// Update logic
			foreach (var product in updatedCartItems)
			{
				product.Total = product.Price * product.Quantity;
			}

			HttpContext.Session.SetString("myCart", JsonConvert.SerializeObject(updatedCartItems));

			return RedirectToAction("Index");
		}
	}
}
