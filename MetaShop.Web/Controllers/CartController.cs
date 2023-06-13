using Microsoft.AspNetCore.Mvc;

namespace MetaShop.Web.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
