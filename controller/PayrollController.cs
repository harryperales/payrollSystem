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
            
            decimal dailyBasedSalary = 0.00M;
            Decimal.TryParse(employee.jobPosition.salary, out dailyBasedSalary);
            decimal periodSalary = salaryService.calculatePeriodSalary(attendances, dailyBasedSalary);

            List<Request> overtimeRequests = requestService.fetchOvertimeRequests(employee, startDatePeriod, endDatePeriod);

            periodSalary += salaryService.calculatePeriodSalaryWithOvertimeRequests(overtimeRequests, dailyBasedSalary);
            Console.WriteLine("periodSalaryWithOvertime---->>" + periodSalary);

            List<Request> leaveRequests = requestService.fetchLeaveRequest(employee, startDatePeriod, endDatePeriod);

            periodSalary += salaryService.calculatePeriodSalaryWithLeaveRequest(leaveRequests, dailyBasedSalary);
            Console.WriteLine("periodSalaryWithLeave---->>" + periodSalary);

            List<Miscellaneous> deductions = miscellaneousService.fetchMiscellaneousByDeductionType(employee);

            periodSalary = salaryService.calculatePeriodSalaryWithDeductions(deductions, periodSalary);
            Console.WriteLine("periodSalaryWIthDeductions---->>" + periodSalary);

            List<Miscellaneous> benefits = miscellaneousService.fetchMiscellaneousByBenefitType(employee);

            periodSalary = salaryService.calculatePeriodSalaryWithBenefits(benefits, periodSalary, attendances, leaveRequests);
            Console.WriteLine("periodSalaryWIthBenefits---->>" + periodSalary);

            List<Miscellaneous> bonuses = miscellaneousService.fetchBonusMiscellaneousByDescriptionAsDate(employee, startDatePeriod, endDatePeriod);
            periodSalary = salaryService.calculatePeriodSalaryWithBonus(bonuses, periodSalary);
            Console.WriteLine("periodSalaryWIthBonus---->>" + periodSalary);

            periodSalary -= salaryService.calculatePeriodSalaryTax(employee, periodSalary);
            Console.WriteLine("periodSalaryWithholdingTax---->>" + periodSalary);
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

            return payrollService.createPayslip();
        }
    }
}
