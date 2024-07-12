using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        public IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(int id, string name, string email, string phone, string address, DateTime admissionDate, double fees, bool status)
        { 
            Students students = new Students(id, name, email,phone,  address, admissionDate, fees, status);
            studentService.Insert(students);
            return View();
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            List<Students> students = studentService.GetAll();
            ViewData["catalog"] = (students);
            return View();
        }

        [HttpGet]
        public IActionResult GetStudentById()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetStudentById(int id)
        {
            Students student=studentService.GetById(id);
            ViewData["catalog"]=(student);
            return View();
        }

        [HttpGet]
        public IActionResult UpdateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Students student)
        {
            studentService.Update(student);
            return RedirectToAction("GetAllStudents","Student");
        }

        [HttpGet]
        public IActionResult DeleteStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
                studentService.Delete(id);
                return RedirectToAction("GetAllStudents", "Student");
        }

        [HttpGet]
        public IActionResult SearchByStatus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchByStatus(bool stat)
        {
           var students= studentService.SearchByStatus(stat);
            ViewData["catalog"] = (students);
            return View();
        }

        [HttpGet]
        public IActionResult SortByName()
        {
            List<Students> stud = studentService.SortStudents();
            ViewData["catalog"] = (stud);
            return View();
        }
    }
}
