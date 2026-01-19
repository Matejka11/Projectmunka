using Microsoft.AspNetCore.Mvc;

namespace Andika_vegyesboltja.Controllers
{
    public class TermekekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
