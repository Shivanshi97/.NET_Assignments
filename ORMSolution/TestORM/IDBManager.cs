using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;
using BOL;

    public interface IDBManager
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        void Insert(Department dept);
        void Update(Department department);
        void Delete(int id);
    }

