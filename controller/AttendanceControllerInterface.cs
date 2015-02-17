using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface AttendanceControllerInterface
    {
        Attendance saveEmployeeAttendance(Attendance attendance);

        Attendance fetchEmployeeAttendanceByDate(Employee employee, DateTime currentDate);

        Attendance updateEmployeeAttendance(Attendance attendance);
    }
}
