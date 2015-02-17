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
            Payslip payslip = new Payslip();
            payslip.employee = employee;
            payslip.startDatePeriod = startDatePeriod;
            payslip.endDatePeriod = endDatePeriod;
            List<Attendance> attendances = attendanceService.fetchEmployeeAttendance(startDatePeriod, endDatePeriod, employee);
            
            decimal dailyBasedSalary = 0.00M;
            Decimal.TryParse(employee.jobPosition.salary, out dailyBasedSalary);
            decimal periodSalary = salaryService.calculatePeriodSalary(attendances, dailyBasedSalary);

            payslip.basePay = periodSalary;
            List<Request> overtimeRequests = requestService.fetchOvertimeRequests(employee, startDatePeriod, endDatePeriod);
            payslip.request = overtimeRequests;

            periodSalary += salaryService.calculatePeriodSalaryWithOvertimeRequests(overtimeRequests, dailyBasedSalary);
            Console.WriteLine("periodSalaryWithOvertime---->>" + periodSalary);

            List<Request> leaveRequests = requestService.fetchLeaveRequest(employee, startDatePeriod, endDatePeriod);
            payslip.request.AddRange(leaveRequests);

            periodSalary += salaryService.calculatePeriodSalaryWithLeaveRequest(leaveRequests, dailyBasedSalary);
            Console.WriteLine("periodSalaryWithLeave---->>" + periodSalary);

            List<Miscellaneous> deductions = miscellaneousService.fetchMiscellaneousByDeductionType(employee);
            payslip.miscellaneous = deductions;

            periodSalary = salaryService.calculatePeriodSalaryWithDeductions(deductions, periodSalary);
            Console.WriteLine("periodSalaryWIthDeductions---->>" + periodSalary);

            List<Miscellaneous> benefits = miscellaneousService.fetchMiscellaneousByBenefitType(employee);
            payslip.miscellaneous.AddRange(benefits);

            periodSalary = salaryService.calculatePeriodSalaryWithBenefits(benefits, periodSalary, attendances, leaveRequests);
            Console.WriteLine("periodSalaryWIthBenefits---->>" + periodSalary);

            List<Miscellaneous> bonuses = miscellaneousService.fetchBonusMiscellaneousByDescriptionAsDate(employee, startDatePeriod, endDatePeriod);
            payslip.miscellaneous.AddRange(bonuses);
            periodSalary = salaryService.calculatePeriodSalaryWithBonus(bonuses, periodSalary);
            Console.WriteLine("periodSalaryWIthBonus---->>" + periodSalary);

            payslip.taxDeduction = salaryService.calculatePeriodSalaryTax(employee, periodSalary);
            periodSalary -= payslip.taxDeduction;

            payslip.netPay = periodSalary;
            Console.WriteLine("periodSalaryWithholdingTax---->>" + periodSalary);

            return payrollService.createPayslip(employee, payslip);
        }
    }
}
