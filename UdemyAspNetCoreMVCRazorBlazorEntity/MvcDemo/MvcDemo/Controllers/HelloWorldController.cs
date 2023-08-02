using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Snoopy", Age = 10 };
            return View(doggo);
        }

        public IActionResult Hello()
        {
            return View();
        }
    }
}
