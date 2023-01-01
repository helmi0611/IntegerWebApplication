using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;


namespace IntegerWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new List<Student>();

            student.Add(new Student()
            {
                Id = 1,
                Name = "Helmi Tris Edyan",
                Addres = "Kota Banjar",
                PhoneNumber = "082117465976"
            });

            student.Add(new Student()
            {
                Id = 2,
                Name = "Dede adam alamsyah",
                Addres = "Banjarsari",
                PhoneNumber = "1234567890"
            });


            return View(student);
        }
    }
}
