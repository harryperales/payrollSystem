﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class EmployeeLeaveCredits
    {
        public int id { get; set; }
        public Employee employee { get; set; }
        public LeaveCredits leaveCredits { get; set; }
    }
}
