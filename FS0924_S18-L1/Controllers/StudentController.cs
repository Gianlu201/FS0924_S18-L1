using FS0924_S18_L1.Models;
using FS0924_S18_L1.Services;
using Microsoft.AspNetCore.Mvc;

namespace FS0924_S18_L1.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllStudents()
        {
            var studentsList = await _studentService.GetAllStudentsAsync();

            return PartialView("_StudentsList", studentsList);
        }

        [HttpGet("Student/Detail/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);

            if (student == null)
            {
                return RedirectToAction("Index");
            }

            return Json(student);
        }
    }
}
