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
        public List<Payslip> fetchUserPayrolls(User user)
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
            dailyBasedSalary = employee.jobPosition.salary;
            decimal periodSalary = salaryService.calculatePeriodSalary(attendances, dailyBasedSalary);

            payslip.basePay = periodSalary;
            List<Request> overtimeRequests = requestService.fetchOvertimeRequests(employee, startDatePeriod, endDatePeriod);
            payslip.requests = overtimeRequests;

            periodSalary += salaryService.calculateDailyBasedSalaryWithOvertimeRequests(overtimeRequests, dailyBasedSalary);
            Console.WriteLine("periodSalaryWithOvertime---->>" + periodSalary);

            List<Request> leaveRequests = requestService.fetchLeaveRequest(employee, startDatePeriod, endDatePeriod);
            payslip.requests.AddRange(leaveRequests);

            periodSalary += salaryService.calculateDailBasedSalaryWithLeaveRequest(leaveRequests, dailyBasedSalary);
            Console.WriteLine("periodSalaryWithLeave---->>" + periodSalary);

            List<Miscellaneous> benefits = miscellaneousService.fetchMiscellaneousByBenefitType(employee);
            payslip.miscellaneous = benefits;

            periodSalary += salaryService.fetchTotalAmountOfBenefits(benefits, attendances, leaveRequests);
            Console.WriteLine("periodSalaryWIthBenefits---->>" + periodSalary);

            //List<Miscellaneous> bonuses = miscellaneousService.fetchBonusMiscellaneousByDescriptionAsDate(employee, startDatePeriod, endDatePeriod);
            //payslip.miscellaneous.AddRange(bonuses);

            //periodSalary += salaryService.fetchTotalBonus(bonuses);
            //Console.WriteLine("periodSalaryWIthBonus---->>" + periodSalary);

            List<Request> cashAdvanceList = requestService.fetchAllApprovedCashAdvanceRequests(startDatePeriod, endDatePeriod, employee);
            periodSalary -= salaryService.fetchTotalCashAdvanceAmount(cashAdvanceList);
            Console.WriteLine("periodSalaryWIthCashAdvance---->>" + periodSalary);

            List<Miscellaneous> deductions = miscellaneousService.fetchMiscellaneousByDeductionType(employee);

            periodSalary -= salaryService.fetchTotalDeductions(deductions);
            Console.WriteLine("periodSalaryWIthDeductions---->>" + periodSalary);

            payslip.sssDeduction = salaryService.fetchSssDeductionsWithPeriodSalary(periodSalary);
            payslip.pagIbigDeduction = salaryService.fetchPagIbigDeductionWithPeriodSalary(periodSalary);
            payslip.philHealthDeduction = salaryService.fetchPhilHealthDeductionWithPeriodSalary(periodSalary);

            payslip.taxDeduction = salaryService.calculatePeriodSalaryTax(employee, periodSalary);
            periodSalary -= payslip.taxDeduction;

            payslip.netPay = periodSalary;
            Console.WriteLine("periodSalaryWithholdingTax---->>" + periodSalary);

            Miscellaneous thirteenMonth = miscellaneousService.calculateThirteenMonth(employee, endDatePeriod);
            return payrollService.createPayslip(employee, payslip);
        }

        public Payslip fetchPayslipById(int payslipId)
        {
            return payrollService.fetchPayslipById(payslipId);
        }

        public List<Payslip> fetchPayroll()
        {
            return payrollService.fetchPayroll();
        }

        public Payslip addThirteenMonthPayToPayslip(Employee employee, Payslip payslip)
        {
            Miscellaneous thirteenMonthPay = miscellaneousService.fetchEmployeeMiscellaneousBenefitByEmployeeId(employee, "ThirteenMonthAllowance");
            return payrollService.updatePayslipThirteenMonthPay(payslip, thirteenMonthPay);
        }
    }
}
