using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VideoGameAgeLimitQuestionnaire.WEB.ViewModels;

namespace VideoGameAgeLimitQuestionnaire.WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Questionnaire()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
