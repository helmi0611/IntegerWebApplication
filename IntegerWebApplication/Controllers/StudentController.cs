using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;


namespace IntegerWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student();
            {
                student.Id = 1;
                student.Name = "Helmi Tris Edyan";
                student.Addres = "Banjar Patroman";
                student.PhoneNumber = "082117465976";
            }
            return View(student);
        }
    }
}
