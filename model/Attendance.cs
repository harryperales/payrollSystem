using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class Attendance
    {
        public int id { get; set; }
        public Employee employee { get; set; }
        public DateTime timeIn { get; set; }
        public DateTime timeOut { get; set; }
    }
}
