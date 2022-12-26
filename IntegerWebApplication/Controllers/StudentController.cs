using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;


namespace IntegerWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new List<Student>();

            student.Add (new Student()
            {

                Id = 1,
                Name = "Helmi Tris Edyan",
                Addres = "Banjar Patroman",
                PhoneNumber = "082117465976"
            });
            student.Add(new Student()
            {

                Id = 2,
                Name = "Dede Adam Alamsyah",
                Addres = "Banjarsari",
                PhoneNumber = "0821111111111"
            });
            return View(student);
        }
    }
}
