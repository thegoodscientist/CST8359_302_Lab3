using CST8359Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace CST8359Lab3.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SongForm() => View();  

        [HttpPost]
        public IActionResult Sing()
        {
            ViewBag.numOfBottles = Request.Form["numOfBottles"];
            return View();
        }

        public IActionResult CreateStudent() => View();

        [HttpPost]
        public IActionResult DisplayStudent(Student student)
        {
            return View(student);
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
