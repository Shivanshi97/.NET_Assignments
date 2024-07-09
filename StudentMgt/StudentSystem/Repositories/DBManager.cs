using StudentSystem.Models;

namespace StudentSystem.Repositories
{
    public class DBManager : IDBManager
    {
        public void AddStudent(Student student)
        {   
            using(var context=new StudentCollectionContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public void RemoveStudent(int id)
        {
            using(var context=new StudentCollectionContext())
            {
                context.Students.Remove(context.Students.Find(id));
                context.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {

            using (var context = new StudentCollectionContext())
            { var student = from stud
                            in context.Students
                            select stud;
                return student.ToList<Student>();
            }
            //throw new NotImplementedException();
        }

        public List<Student> SearchByStatus(string status)
        {
            using (var context = new StudentCollectionContext())
            {
                var student = from stud
                            in context.Students
                            where stud.Status == status
                              select stud;

                return student.ToList<Student>();
            }
            //throw new NotImplementedException();
        }

        public Student SearchById(int id)
        {
            using (var context = new StudentCollectionContext())
            {
                var student = context.Students.Find(id);

                return student;
            }
            //throw new NotImplementedException();
        }

        public Student EditStudent(Student student)
        {
            using (var context = new StudentCollectionContext())
            {
                // Student student1 = context.Students.Find(student.Id);
                Student upStudent = context.Students.Find(student.Id);
                upStudent.Name = student.Name;
                upStudent.Email = student.Email;
                upStudent.MobileNumber = student.MobileNumber;
                upStudent.Address = student.Address;
                upStudent.AdmissionDate = student.AdmissionDate;
                upStudent.Fees = student.Fees;
                upStudent.Status = student.Status;

                //context.Students.Update(context.Students.Find(student.Id));
                context.SaveChanges();
                return upStudent;
            }
            //throw new NotImplementedException();
        }

        public List<Student> SortStudent()
        {
            using(var context = new StudentCollectionContext())
            {
                /*List<Student> sortedList = context.Students.OrderBy(s=>s.Status).ToList();
                return sortedList;*/

                
                var student = from stud
                            in context.Students
                            orderby stud.Status
                              select stud;
                return student.ToList<Student>();
            }
            //throw new NotImplementedException();
        }

        public Student LoginStudent(string email, int mobilenumber)
        {
            using (var context = new StudentCollectionContext())
            {
                // var student = context.Students.Find(email, mobilenumber);
                var student = (from std
                             in context.Students
                              where std.Email == email /*&& std.MobileNumber == mobilenumber*/
                              select std).FirstOrDefault();

                return student;
            }

          //  throw new NotImplementedException();
        }
    }
}
