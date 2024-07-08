using Microsoft.AspNetCore.Mvc;

namespace StudentSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
