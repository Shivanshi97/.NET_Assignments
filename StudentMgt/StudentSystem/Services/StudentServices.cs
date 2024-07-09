using StudentSystem.Models;
using StudentSystem.Repositories;

namespace StudentSystem.Services
{
    public class StudentServices : IStudentServices
    {
        private IDBManager _idbmanager;
        public StudentServices (IDBManager idbmanager)
        {
            _idbmanager = idbmanager;
        }

        

        public List<Student> GetStudents()
        {
            return _idbmanager.GetAllStudents();
            //throw new NotImplementedException();
        }

        public List<Student> GetStudentByStatus(string status)
        {
            return _idbmanager.SearchByStatus(status);
            //throw new NotImplementedException();
        }

        public void InsertStudent(Student student)
        {
            _idbmanager.AddStudent(student);
            //throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            _idbmanager.RemoveStudent(id);
            //throw new NotImplementedException();
        }

        public Student UpdateStudent(Student student)
        {
            return _idbmanager.EditStudent(student);
            //throw new NotImplementedException();
        }

        public List<Student> SortStudentByStatus()
        {   
            return _idbmanager.SortStudent();
            //throw new NotImplementedException();
        }

        public Student Login(string email, int mobilenumber)
        {
            return _idbmanager.LoginStudent(email, mobilenumber);
            //throw new NotImplementedException();
        }
    }
}