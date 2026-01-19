using Microsoft.AspNetCore.Mvc;
using Andika_vegyesboltja.Models;

namespace Andika_vegyesboltja.Controllers
{
    public class TermekekController : Controller
    {
        static List<Termekek> termekeks = new List<Termekek>()
        {
            new Termekek
            {
                Id = 1, Name="Nápolyi", Price = 599
            }
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
