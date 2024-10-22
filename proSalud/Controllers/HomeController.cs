using Microsoft.AspNetCore.Mvc;
using proSalud.Models;
using System.Diagnostics;

namespace proSalud.Controllers
{
    public class HomeController : Controller
    {
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

        public PartialViewResult Appointments()
        {
            return PartialView("_Appointments");
        }

        public PartialViewResult PatientInfo()
        {
            return PartialView("_PatientInfo");
        }

        public PartialViewResult Billing()
        {
            return PartialView("_Billing");
        }

        public PartialViewResult MedicalServices()
        {
            return PartialView("_MedicalServices");
        }

        public PartialViewResult StatisticsMembership()
        {
            return PartialView("_StatisticsMembership");
        }
    }
}
