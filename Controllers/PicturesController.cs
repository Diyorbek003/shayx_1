using Microsoft.AspNetCore.Mvc;

namespace shayx.Controllers
{
    public class PicturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
