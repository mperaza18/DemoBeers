using Microsoft.AspNetCore.Mvc;

namespace DemoBeers.Api.Controllers
{
    public class BeersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
