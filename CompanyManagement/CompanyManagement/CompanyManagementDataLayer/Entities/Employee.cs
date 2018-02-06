using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEntities
{
    public class Employee
    {

        public String fname { get; set; }
        public String lname { get; set; }
        public String email { get; set; }
        public int phoneNumber { get; set; }
        public DateTime hireDate { get; set; }
        public int departmentMasterId { get; set; }
        public int salary { get; set; }
    }
}
