namespace StudentSystem.Models
{
    public class Student
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public string Email { get; set;}

        public Student() { }
        public Student(int id, string name, string email, int mobileNumber, string address, DateTime admissionDate, double fees, string status)
        {
            Id = id;
            Name = name;
            Email = email;
            MobileNumber = mobileNumber;
            Address = address;
            AdmissionDate = admissionDate;
            Fees = fees;
            Status = status;
        }

       

        public int MobileNumber { get; set;}

        public string Address { get; set;}

        public DateTime AdmissionDate { get; set;}

        public double Fees { get; set;}

        public string Status { get; set; }

        public override string? ToString()
        {
            //return base.ToString();
            return "Id: "+Id+" Name: "+Name+" Email: " + Email + 
                " Mobile Number: "+MobileNumber+" Address: "+Address+" AdmissionDate: "+ 
                AdmissionDate+" Fees: "+Fees+" Status: "+Status;
        }
    }
}
