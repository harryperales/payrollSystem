using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class Holiday
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public HolidayWages holidayWages { get; set; }
    }
}
