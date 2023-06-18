using Microsoft.AspNetCore.Mvc;

namespace MetaShop.Web.Controllers
{
    [Route("about")]
    public class AboutUsController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
