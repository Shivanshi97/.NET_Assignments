using StudentSystem.Models;

namespace StudentSystem.Repositories
{
    public interface IDBManager
    {
        List<Student> GetAllStudents();

        List<Student> SearchByStatus(string status);

        Student SearchById(int id);

        void AddStudent(Student student);

        void RemoveStudent(int id);

        Student EditStudent(Student student);

        List<Student> SortStudent();

        Student LoginStudent(string email, int mobilenumber);

    }
}
 