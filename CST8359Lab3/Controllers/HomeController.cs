using Microsoft.AspNetCore.Mvc;

namespace CST8359Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            // you will complete this
        }

        public IActionResult CreateStudent() => View();

        [HttpPost]
        public IActionResult DisplayStudent(Student student)
        {
            // you will complete this
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
