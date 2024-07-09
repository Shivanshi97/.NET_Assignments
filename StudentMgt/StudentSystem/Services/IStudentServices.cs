using StudentSystem.Models;

namespace StudentSystem.Services
{
    public interface IStudentServices
    {
        List<Student> GetStudents();

        List<Student> GetStudentByStatus(string status);

        void InsertStudent(Student student);

        void DeleteStudent(int id);

        Student UpdateStudent(Student student);

        List<Student> SortStudentByStatus();

        Student Login(string email, int mobilenumber);
    }
}
