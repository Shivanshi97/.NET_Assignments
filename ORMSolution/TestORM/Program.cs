using BOL;
using DAL;

IDBManager idbm= new DBManager();  

Console.WriteLine("Welcome to ECommerce ORM SOlution");

while (true)
{
    Console.WriteLine("1. GetAll \n2. Insert \n3. GetOne \n4.Update \n5.Delete");

    Console.WriteLine("Enter your choice : ");
    int choice= Convert.ToInt32(Console.ReadLine());

   

    switch (choice)
    {
        case 1: Console.WriteLine("List of departments");

            List<Department> list = idbm.GetAllDepartments();

            foreach (var department in list)
            { 
                Console.WriteLine("Id {0}, Name {1}, Location {2} ",
                    department.Id,department.Name, department.Location);
            }
            break;

        case 2: Console.WriteLine("Insert");
            Console.WriteLine("Enter Details: Id, Name, Location");
            Department dept= new Department(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            idbm.Insert(dept);
            break;

        case 3:
            Console.WriteLine("GetOne");
            Console.WriteLine("Enter Id:");
            int deptid= int.Parse(Console.ReadLine());

            Department dept1 = idbm.GetDepartmentById(deptid);

            Console.WriteLine("Id: "+dept1.Id+", Name:" + dept1.Name+", Location: " +dept1.Location);
            break;

        case 4:
            Console.WriteLine("Update");
            Console.WriteLine("Enter Details: Id, NewName, NewLocation");
            Department dept2 = new Department(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            idbm.Update(dept2);

            break;

        case 5:
            Console.WriteLine("Delete");
            Console.WriteLine("Enter Id:");
            int did = int.Parse(Console.ReadLine());

            idbm.Delete(did);
            Console.WriteLine("1 record deleted");
            idbm.GetAllDepartments();

            break;
    }
}
