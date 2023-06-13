using Microsoft.AspNetCore.Mvc;

namespace HomeManager.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
