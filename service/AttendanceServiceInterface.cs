using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface AttendanceServiceInterface
    {
        List<Attendance> fetchEmployeeAttendance(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee);

        Attendance addEmployeeTimeIn(Attendance attendance);

        Attendance fetchEmployeeAttendanceByDate(Employee employee, DateTime date);

        Attendance updateEmployeeAttendance(Attendance attendance);
    }
}
