using BOL;
using DAL;

IDBManager idbm= new DBManager();  

Console.WriteLine("Welcome to ECommerce ORM SOlution");

while (true)
{
    Console.WriteLine("1. GetAll \n2. Insert \n3. GetOne");

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
            int id= int.Parse(Console.ReadLine());

            Department dept1 = idbm.GetDepartment(id);

            Console.WriteLine("Id: , Name:, Location: "+
                     dept1.Id, dept1.Name, dept1.Location);
            break;

    }
}
