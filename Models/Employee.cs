using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_App.Models
{   
    public enum Department
    {
        Administration, Marketing, HR, Finance, Software
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Position { get; set; }
        public Department Department { get; set; }
        public double Salary { get; set; }
        public DateTime DateEmployed { get; set; }
        public DateTime LastUpdated { get; set; }


    }
}
