using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string nome, int numtimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Oi {nome}, ID: {ID}");
            ////return "Wellcome";
            ViewData["Message"] = "oi "+ nome;
            ViewData["NumTimes"] = numtimes;

            return View();
        }
    }
}
