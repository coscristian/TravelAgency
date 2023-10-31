using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelAgency.Models.ViewModels;

namespace TravelAgency.Areas.GeneralAdmin.Controllers
{
    [Area("GeneralAdmin")]
    public class GeneralAdminController : Controller
    {
        private readonly ILogger<GeneralAdminController> _logger;

        public GeneralAdminController(ILogger<GeneralAdminController> logger)
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