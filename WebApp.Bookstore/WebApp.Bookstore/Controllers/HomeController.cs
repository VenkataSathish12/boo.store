using Microsoft.AspNetCore.Mvc;

namespace WebApp.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "WebApplication Book Store";
        }
    }
}
