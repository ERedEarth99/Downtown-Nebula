using Microsoft.AspNetCore.Mvc;

namespace DNR.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
