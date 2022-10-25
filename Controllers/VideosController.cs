using Microsoft.AspNetCore.Mvc;

namespace shayx.Controllers
{
    public class VideosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
