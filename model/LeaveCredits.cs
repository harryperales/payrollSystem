using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class LeaveCredits
    {
        public int id { get; set; }
        public int vacationLeaveCredits { get; set; }
        public int sickLeaveCredits { get; set; }
        public int paternityLeaveCredits { get; set; }
        public int emergencyLeaveCredits { get; set; }
        public int birthdayLeaveCredits { get; set; }
        public int bereavementLeaveCredits { get; set; }
    }
}
