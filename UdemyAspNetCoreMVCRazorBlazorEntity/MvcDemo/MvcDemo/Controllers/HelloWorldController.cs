using Microsoft.AspNetCore.Mvc;

namespace MvcDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hello()
        {
            return View();
        }
    }
}
