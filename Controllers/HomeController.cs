using Microsoft.AspNetCore.Mvc;
using MetricConversion.Models;

namespace MetricConversion.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Conversion()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Conversion(ConversionEntries entries)
        {
            //TODO: store entries from user
            return View("Results", entries);
        }
    }
}
