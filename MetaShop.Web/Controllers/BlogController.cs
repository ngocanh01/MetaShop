using Microsoft.AspNetCore.Mvc;

namespace MetaShop.Web.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("details")]
        public IActionResult Details()
        {
            return View();
        }
    }
}
