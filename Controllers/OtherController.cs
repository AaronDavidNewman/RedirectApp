using Microsoft.AspNetCore.Mvc;

namespace RedirectApp.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
