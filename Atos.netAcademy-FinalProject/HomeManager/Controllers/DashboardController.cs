using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace HomeManager.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult DashboardGeral()
        {
            return View("~/Views/dashboard/GeralIndex.cshtml");
        }
        public IActionResult PatrimonioDashboard()
        {   

            return View("~/Views/dashboard/PatrimonioIndex.cshtml");
        }



    }
}
