using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class Miscellaneous
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal amount { get; set; }
        public string description { get; set; }
        public MiscType type { get; set; }
    }
}
