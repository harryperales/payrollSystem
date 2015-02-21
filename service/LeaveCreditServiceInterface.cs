using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface LeaveCreditServiceInterface
    {
        EmployeeLeaveCredits createEmployeeLeaveCredits(Employee employee);

        LeaveCredits fetchLeaveCreditsByEmployee(Employee employee);

        EmployeeLeaveCredits updateEmployeeLeaveCredits(Employee employee, LeaveCredits leaveCredits);
    }
}
