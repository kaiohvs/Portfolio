using Microsoft.AspNetCore.Mvc;

namespace Portfolio.MVC.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
