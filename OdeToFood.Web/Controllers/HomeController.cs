using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OdeToFood.Web.Models;
using OdeToFood.Data.Services;// to add this reference to a separate project,
                              // go to the project root,
                              // in this case OdeToFood.Web and click add and then in the settings section
                              // add the project you'd like to use - that will allow you to use the
                              // other projects 

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
        
    {
        IRestaurantData db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
