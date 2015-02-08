using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class Payroll
    {
        public int id { get; set; }
        public Employee employee { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime payableDate { get; set; }
        public Earnings earnings { get; set; }
        public Deductions deductions { get; set; }
        public Allowances allowances { get; set; }
        public Adjustments adjustments { get; set; }

    }
}
