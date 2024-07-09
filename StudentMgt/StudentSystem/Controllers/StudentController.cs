using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1;
using StudentSystem.Models;
using StudentSystem.Services;
using System.Xml.Linq;

namespace StudentSystem.Controllers
{
    public class StudentController : Controller
    {
        private IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        public IActionResult Index()
        {
            //return Json(_studentServices.GetStudents());
            List<Student> students = _studentServices.GetStudents();
            ViewData["details"] = students;
            return View(students);
        }

        public IActionResult Search(string status)
        {
            //return Json(_studentServices.GetStudentByStatus(status));
            List<Student> students = _studentServices.GetStudentByStatus(status);
            ViewData["status"] = students;
            return View(students);
        }

        public IActionResult Insert(Student student)
        {

            Student newStudent = new Student();
            newStudent.Id = student.Id;
            newStudent.Name = student.Name;
            newStudent.Email = student.Email;
            newStudent.MobileNumber = student.MobileNumber;
            newStudent.Address = student.Address;
            newStudent.AdmissionDate = student.AdmissionDate;
            newStudent.Fees = student.Fees;
            newStudent.Status = student.Status;

            
            _studentServices.InsertStudent(newStudent);
            ViewData["addStudent"] = newStudent;  
            //return Json(newStudent);
            return RedirectToAction("index", "student");
        }

        public IActionResult Delete(int id)
        {
            _studentServices.DeleteStudent(id);
            return RedirectToAction("index", "student");
        }

        public IActionResult Edit(Student student)
        {
            //Student updatedStudent = new Student(int id, string name, string email, int mobileNumber, string address, DateTime admissionDate, double fees, string status);
            _studentServices.UpdateStudent(student);
            return RedirectToAction("index", "student");
        }

        public IActionResult SortStatus()
        {
            List<Student> students = _studentServices.SortStudentByStatus();
            ViewData["sorted"] = students;
            return View(students);
            // return Json(_studentServices.SortStudentByStatus());
        }

        public IActionResult StudentDetails(string email, int mobilenumber)
        {
            Student s = _studentServices.Login(email, mobilenumber);
            ViewData["logged"] = s;
            return View(s);
        }
    }
}
