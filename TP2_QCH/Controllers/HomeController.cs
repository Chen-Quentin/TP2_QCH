using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP2_QCH.Models;

namespace TP2_QCH.Controllers
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

        public IActionResult Form()
        {
            return View();
        }
        public IActionResult ValidateForm(FormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("ValidateForm", model);
            }
            return View("Form", model);
        }
        public IActionResult ListPage()
        {
            string filePath = "XlmFile/DataAvis.xml";
            var reviews = new ListReviews().GetAvis(filePath);
            return View(reviews);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}