using Microsoft.AspNetCore.Mvc;

namespace MetaShop.Web.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
