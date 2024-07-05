using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;
using BOL;


    public class DBManager : IDBManager
{
        public List<Department> GetAllDepartments()
        {
            //SQL: select * from departments;

            using (var context = new CollectionContext())       //Deterministic Finalisation
            {
                //LINQ:
                var departments = from dept 
                                  in context.Departments 
                                  select dept;

                return departments.ToList<Department>();
            }
            //throw new NotImplementedException();
        }
        
        public Department GetDepartment(int id)
        {
            using (var context = new CollectionContext())
            {
                //LINQ
                /*var department = from dept in context.Departments
                                  where dept.Id == id
                                  select dept;
                return department.FirstOrDefault();
                */

                Department dept=context.Departments.Find(id);
                return dept;
            }
                //throw new NotImplementedException();
        }

        public void Insert(Department dept)
        {
        using (var context = new CollectionContext())
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
       // throw new NotImplementedException();
        }

        public void Update(Department department)
        {
           // throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }
    }

