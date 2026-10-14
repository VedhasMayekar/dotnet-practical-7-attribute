using Microsoft.AspNetCore.Mvc;
using pract7.Models;

namespace pract7.Controllers
{
    [Route("student")]
    public class StudentController : Controller
    {
        // GET: /student/create
        [HttpGet("create")]
        public IActionResult Create()
        {
            ViewBag.Greetings = "Hello, Please enter Student Details !!";
            return View();
        }

        // POST: /student/create
        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                TempData["Id"] = student.Id;
                TempData["Name"] = student.Name;
                TempData["Course"] = student.Course;
                return RedirectToAction(nameof(Details));
            }

            ViewBag.Greetings = "Hello, Please enter Student Details !!";
            return View(student);
        }

        // GET: /student/details
        [HttpGet("details")]
        public IActionResult Details()
        {
            if (TempData["Id"] != null && TempData["Name"] != null && TempData["Course"] != null)
            {
                var id = Convert.ToInt32(TempData["Id"]);
                var name = TempData["Name"]?.ToString();
                var course = TempData["Course"]?.ToString();
                return Content($"Student Details -\n1. Student Id : {id}\n2. Student Name : {name}\n3. Student Course : {course}");
            }

            return Content("No Student Details Found. Please Submit the Form first !!!");
        }

        // Attribute-routed endpoint
        [HttpPost("detailed")]
        public IActionResult Detailed(int id, string name, string course)
        {
            return Content($"Student Details -\n1. Student Id : {id}\n2. Student Name : {name}\n3. Student Course : {course}");
        }
    }
}
