using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class Request
    {
        public int id { get; set; }
        public Employee employee { get; set; }
        public string name { get; set; }
        public DateTime requestedDate { get; set; }
        public DateTime dateFiled { get; set; }
        public RequestStatus status { get; set; }
        public string description { get; set; }
    }
}
