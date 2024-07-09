using Microsoft.AspNetCore.Mvc;
using StudentSystem.Models;
using StudentSystem.Services;

namespace StudentSystem.Controllers
{
    public class AuthController : Controller
    {
        private IStudentServices _studentServices;
        public AuthController(IStudentServices studentServices) 
        {
            _studentServices = studentServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(int id, string name, string email, int mobileNumber, 
            string address, DateTime admissionDate, double fees, string status)
        {
            return RedirectToAction("register");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, int mobilenumber)
        {
            if (email == "admin@gmail.com" && mobilenumber == 123)
            {
                return RedirectToAction("index", "student");
            }
            else
            {
                Student student = _studentServices.Login(email, mobilenumber);
                ViewData["logged"] = student;
                return RedirectToAction("studentdetails", "student");
               // return View();
            }
           // return View();
        }
    }
}
