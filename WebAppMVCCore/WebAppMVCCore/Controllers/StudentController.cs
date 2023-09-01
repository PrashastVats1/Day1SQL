using Microsoft.AspNetCore.Mvc;
using WebAppMVCCore.Models;

namespace WebAppMVCCore.Controllers
{
    public class StudentController : Controller
    {
        List<Student> listStudents = new List<Student>()
        {
            new Student() {Id=1,Name="Sam",Class="Five",Fee=5000.50},
            new Student() {Id=2,Name="Deep",Class="Five",Fee=5000.50},
            new Student() {Id=3,Name="Soniya",Class="Four",Fee=5000.50},
            new Student() {Id=4,Name="Renu",Class="Four",Fee=5000.50},
            new Student() {Id=5,Name="Shiba",Class="Three",Fee=5000.50},
        };
        public IActionResult Index()
        {
            return View(listStudents);
        }
    }
}
