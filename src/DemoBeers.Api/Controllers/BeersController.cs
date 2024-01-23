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

    public class Beer
    {
        public string Name { get; set; }
        public string Pack { get; set; }
        public decimal AbvPercentage { get; set; }
        public int Ibu { get; set; }
        public string Description { get; set; }
    }
}
