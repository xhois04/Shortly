using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Shortly.Client.Data.Models;


namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        var tempData = TempData["SuccessMessage"];
        var viewBag = ViewBag.Test1;
        var viewData = ViewData["Test2"];
        public IActionResult Index()
        {
            if (TempData["SuccessMessage"] != null) {
                ViewBag.SuccessMessage = TempData["SuccessMessage"].ToString();
            }
            return View();
        }
        public IActionResult Create()
        {
            //Shorten Url
            var shortenedURL = "short";

            TempData["SuccessMessage"] = "Successuful";
            ViewBag.Test1 = "test1";
            ViewData["Test2"] = "test2";

            return RedirectToAction("Index");
        }
    }
}
