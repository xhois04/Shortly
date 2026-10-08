using Microsoft.AspNetCore.Mvc;

namespace Shortly.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShortenAction(string urlToShorten)
        {
            TempData["SuccessMessage"] = $"Received: {urlToShorten}";
            return RedirectToAction("Index", "Url");
        }
    }
}