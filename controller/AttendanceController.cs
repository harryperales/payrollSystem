using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using PayrollSystem.service;

namespace PayrollSystem.controller
{
    public class AttendanceController : AttendanceControllerInterface
    {
        AttendanceServiceInterface attendanceService;
        public AttendanceController()
        {
            attendanceService = new AttendanceService();
        }

        public AttendanceController(AttendanceServiceInterface attendanceService)
        {
            this.attendanceService = attendanceService;
        }

        public Attendance saveEmployeeAttendance(Attendance attendance)
        {
            return attendanceService.addEmployeeTimeIn(attendance);
        }
        
        public Attendance fetchEmployeeAttendanceByDate(Employee employee, DateTime currentDate)
        {
            return attendanceService.fetchEmployeeAttendanceByDate(employee, currentDate);
        }

        public Attendance updateEmployeeAttendance(Attendance attendance)
        {
            return attendanceService.updateEmployeeAttendance(attendance);
        }

        public List<Attendance> fetchEmployeeAttendance(Employee employee)
        {
            return attendanceService.fetchEmployeeAttendance(employee);
        }
    }
}
