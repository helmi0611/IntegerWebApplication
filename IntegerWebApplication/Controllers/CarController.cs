using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace IntegerWebApplication.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            /*var cars = new List<Car>();

            cars.Add(new Car()
            {
                IDRegistration = 1,
                Type = "Sedan",
                Brand = "BMW",
                Varian = "White"
            });
            cars.Add(new Car()
            {
                IDRegistration = 2,
                Type = "Sedan",
                Brand = "BMW",
                Varian = "Black"
            });
            cars.Add(new Car()
            {
                IDRegistration = 3,
                Type = "Sedan",
                Brand = "Toyota",
                Varian = "Red"
            });*/

            var cars = new Car[]
            {
                new Car{IDRegistration = 1, Type ="Sedan", Brand= "Toyota", Varian="FT86"},
                new Car{IDRegistration = 2, Type ="SUV", Brand= "Honda", Varian="ACV"},
                new Car{IDRegistration = 3, Type ="Sedan", Brand= "BMW", Varian="ADX"},
                new Car{IDRegistration = 4, Type ="SUV", Brand= "Buggati", Varian="Accord"}
            };

            var car = cars.Where(x => x.Type == "Sedan").FirstOrDefault();
            ViewBag.Cars = new List<Car>() { car};

            return View();
        }
    }
}
