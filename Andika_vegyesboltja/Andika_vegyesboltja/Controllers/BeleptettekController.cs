using Microsoft.AspNetCore.Mvc;
using Andika_vegyesboltja.Models;

namespace Andika_vegyesboltja.Controllers
{
    public class BeleptettekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
