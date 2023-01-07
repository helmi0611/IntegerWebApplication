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
            var cars = new Car[]{
                new Car{IDRegistration = 1, Type= "Sedan", Brand = "Toyota", Varian = "FT86"},
                new Car{IDRegistration = 2, Type = "SUV", Brand = "Toyota", Varian = "RAV4"},
                new Car{IDRegistration = 3, Type = "Sedan", Brand = "Honda", Varian = "Accord"},
                new Car{IDRegistration = 4, Type = "SUV", Brand = "Honda", Varian = "CRV"},
                new Car{IDRegistration = 5, Type = "Sedan", Brand = "Honda", Varian = "City"},
            };
            
            //No 1
            var Soal1 = cars.Where(x => x.Brand == "Honda").FirstOrDefault(); //Kalau pake ini harus pakai list yang datanya 1
            ViewBag.Satu = new List<Car>() {Soal1};

            //No2
            var Soal2 = cars.Where(x => (x.Brand == "Honda" && x.Type =="Sedan"));
            ViewBag.Dua = Soal2;

            //
            var Soal3 = cars.Where(x => (x.Brand == "Honda" && x.Varian =="City")).FirstOrDefault(); 
            ViewBag.Tiga = new List<Car>() { Soal3 };

            //No4
            var Soal4 = cars.Where(x => x.Brand == "Toyota");
            ViewBag.Empat = Soal4;

            //No5
            var Soal5 = cars.Where(x => x.Varian == "City");
            ViewBag.Lima = Soal5;

            //No6
            var Soal6 = cars.Where(x => x.Brand == "Honda");
            ViewBag.Enam = Soal6;

            return View();
        }
    }
}
