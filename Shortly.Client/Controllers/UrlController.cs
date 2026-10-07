using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;


namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            //Data is from DB
            var urlDb = new Url()
            {
                Id = 1,
                OriginalLink = "https://original.com",
                ShortLink = "shrtly",
                NrOfClicks = 1,
                UserId = 1,
            };
            
            return View(urlDb);
        }
    }
}
