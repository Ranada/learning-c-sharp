using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            DogViewModel dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
            //return View("Index");
        }

        public IActionResult Hello()
        {
            DogViewModel doge = new DogViewModel();
            doge.Name = "Shiba";
            doge.Age = 5;
            return View(doge);
        }
    }
}
