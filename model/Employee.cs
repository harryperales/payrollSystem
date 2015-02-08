using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class Employee
    {
        public int id { get; set; }
        public long employeeId { get; set; }
        public User userAccount { get; set; }
        public string fullName { get; set; }
        public string birthDate { get; set; }
        public string gender { get; set; }
        public string civilStatus { get; set; }
        public int dependents { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        public string tin { get; set; }
        public string sssId { get; set; }
        public string pagIbigId { get; set; }
        public string philHealthId { get; set; }
        public string dateEmployed { get; set; }
        public Position jobPosition { get; set; }
        
    }
}
