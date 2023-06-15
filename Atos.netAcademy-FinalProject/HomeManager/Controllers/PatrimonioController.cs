using Microsoft.AspNetCore.Mvc;

namespace Apresentacao.Controllers
{
    public class PatrimonioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
    }
}
