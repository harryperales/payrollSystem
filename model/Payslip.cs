using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class Payslip
    {
        public int id { get; set; }
        public Employee employee { get; set; }
        public DateTime startDatePeriod { get; set; }
        public DateTime endDatePeriod { get; set; }
        public DateTime dateCreated { get; set; }
        public decimal basePay { get; set; }
        public decimal taxDeduction { get; set; }
        public decimal sssDeduction { get; set; }
        public decimal pagIbigDeduction { get; set; }
        public decimal philHealthDeduction { get; set; }
        public decimal netPay { get; set; }
        public List<Request> requests { get; set; }
        public List<Miscellaneous> miscellaneous { get; set; }
        //public 
    }
}
