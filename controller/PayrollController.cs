using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.service;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public class PayrollController : PayrollControllerInterface
    {
        PayrollServiceInterface payrollService;
        AttendanceServiceInterface attendanceService;
        SalaryServiceInterface salaryService;
        RequestServiceInterface requestService;
        MiscellaneousServiceInterface miscellaneousService;
        public PayrollController()
        {
            payrollService = new PayrollService();
            attendanceService = new AttendanceService();
            salaryService = new SalaryService();
            requestService = new RequestService();
            miscellaneousService = new MiscellaneousService();
        }
        public List<Payroll> fetchUserPayrolls(User user)
        {
            return payrollService.fetchUserPayrolls(user);
        }

        public Payslip createPayslip(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee)
        {
            // attendanceLogSheet
            List<Attendance> attendances = attendanceService.fetchEmployeeAttendance(startDatePeriod, endDatePeriod, employee);
            //int hoursSpent = attendanceService.calcuteSalary(attendances);
            decimal dailyBasedSalary = 0.00M;
            Decimal.TryParse(employee.jobPosition.salary, out dailyBasedSalary);
            decimal periodSalary = salaryService.calculatePeriodSalary(attendances, dailyBasedSalary);

            List<Request> overtimeRequests = requestService.fetchOvertimeRequests(employee, startDatePeriod, endDatePeriod);

            periodSalary += salaryService.calculatePeriodSalaryWithOvertimeRequests(overtimeRequests, dailyBasedSalary);
            Console.WriteLine("periodSalary---->>" + periodSalary);

            List<Request> leaveRequests = requestService.fetchLeaveRequest(employee, startDatePeriod, endDatePeriod);

            periodSalary += salaryService.calculatePeriodSalaryWithLeaveRequest(leaveRequests, dailyBasedSalary);

            List<Miscellaneous> deductions = miscellaneousService.fetchMiscellaneousByDeductionType(employee);

            // fetch all request from that has an approved status within the inclusive dates
            // List<Request> listOfRequest = attendanceService.fetchEmployeeRequest(startDatePeriod, endDatePeriod, employee);
            // * type of request
            //  - OVERTIME ?
            //  - UNDERTIME ?
            //  - VACATION_LEAVE
            //  - SICK_LEAVE
            //  - BEREAVEMENT_LEAVE
            //  - PATERNITY_LEAVE
            //  - MATERNITY_LEAVE
            //  - MISSED_TIME_IN
            //  - MISSED_TIME_OUT

            // 
            // if missed_time_in_time_out, check attendance if the date of *typeOf_request is available and if exists, update time_in_time_out
            // just check and clear everything
            // get the employee salary and calculate            


            // List<Holiday> holidays = holidayService.fetchAllHolidays(DateTime.Now.Year);
            // decimal 
            return payrollService.createPayslip();
        }
    }
}
