using System;

namespace CompanyEntities
{
    public class Employee
    {

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int DepartmentMasterId { get; set; }
        public int Salary { get; set; }
    }
}
