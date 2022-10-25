using Microsoft.AspNetCore.Mvc;

namespace Shayx_MuxammadSodiq_MuhammadYusuf.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tafsiri_hilol()
        {
            return View();
        }
        public IActionResult HAdisvaHayot()
        {
            return View();
        }
        public IActionResult Xislatlihikmatlar()
        {
            return View();
        }
        public IActionResult Boshqa() 
        {
            return View(); 
        }
    }
}
