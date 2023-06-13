using MetaShop.Business.Interfaces;
using MetaShop.Business.Services;
using MetaShop.DAL.Entities;
using MetaShop.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MetaShop.Web.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICategoryService _categoryService;
        private IProductService _productService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, IProductService productService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _productService = productService;
        }
        [Route("~/")]
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