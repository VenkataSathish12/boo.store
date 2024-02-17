using Microsoft.AspNetCore.Mvc;

namespace WebApp.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //return View("TempView/NewView.cshtml");
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
