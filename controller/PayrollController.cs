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
        private int AVERAGE_WORKING_DAY_PER_MONTH = 24;
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
            decimal monthlySalary = decimal.Multiply(employee.jobPosition.salary, AVERAGE_WORKING_DAY_PER_MONTH);
            
            decimal dailyBasedSalary = 0.00M;
            dailyBasedSalary = employee.jobPosition.salary;
            decimal periodSalary = decimal.Round(salaryService.calculatePeriodSalary(attendances, dailyBasedSalary), 2);

            payslip.basePay = periodSalary;
            List<Request> overtimeRequests = requestService.fetchOvertimeRequests(employee, startDatePeriod, endDatePeriod);
            payslip.requests = overtimeRequests;

            periodSalary += decimal.Round(salaryService.calculateDailyBasedSalaryWithOvertimeRequests(overtimeRequests, dailyBasedSalary), 2);
            Console.WriteLine("periodSalaryWithOvertime---->>" + periodSalary);

            List<Request> leaveRequests = requestService.fetchLeaveRequest(employee, startDatePeriod, endDatePeriod);
            payslip.requests.AddRange(leaveRequests);

            periodSalary += decimal.Round(salaryService.calculateDailBasedSalaryWithLeaveRequest(leaveRequests, dailyBasedSalary), 2);
            Console.WriteLine("periodSalaryWithLeave---->>" + periodSalary);

            List<Miscellaneous> benefits = miscellaneousService.fetchMiscellaneousByBenefitType(employee);
            payslip.miscellaneous = benefits;

            periodSalary += decimal.Round(salaryService.fetchTotalAmountOfBenefits(benefits, attendances, leaveRequests), 2);
            Console.WriteLine("periodSalaryWIthBenefits---->>" + periodSalary);

            //List<Miscellaneous> bonuses = miscellaneousService.fetchBonusMiscellaneousByDescriptionAsDate(employee, startDatePeriod, endDatePeriod);
            //payslip.miscellaneous.AddRange(bonuses);

            //periodSalary += salaryService.fetchTotalBonus(bonuses);
            //Console.WriteLine("periodSalaryWIthBonus---->>" + periodSalary);

            List<Request> cashAdvanceList = requestService.fetchAllApprovedCashAdvanceRequests(startDatePeriod, endDatePeriod, employee);
            periodSalary -= decimal.Round(salaryService.fetchTotalCashAdvanceAmount(cashAdvanceList), 2);
            Console.WriteLine("periodSalaryWIthCashAdvance---->>" + periodSalary);

            //List<Miscellaneous> deductions = miscellaneousService.fetchMiscellaneousByDeductionType(employee);

            //periodSalary -= decimal.Round(salaryService.fetchTotalDeductions(deductions), 2);

            payslip.sssDeduction = decimal.Divide(salaryService.fetchSssDeductionsWithPeriodSalary(monthlySalary), 2);
            payslip.sssDeduction = decimal.Round(payslip.sssDeduction, 2);

            payslip.pagIbigDeduction = decimal.Divide(salaryService.fetchPagIbigDeductionWithPeriodSalary(monthlySalary), 2);
            payslip.pagIbigDeduction = decimal.Round(payslip.pagIbigDeduction, 2);

            payslip.philHealthDeduction = decimal.Divide(salaryService.fetchPhilHealthDeductionWithPeriodSalary(monthlySalary), 2);
            payslip.philHealthDeduction = decimal.Round(payslip.philHealthDeduction, 2);

            periodSalary -= payslip.sssDeduction;
            periodSalary -= payslip.pagIbigDeduction;
            periodSalary -= payslip.philHealthDeduction;
            Console.WriteLine("periodSalaryWIthDeductions---->>" + periodSalary);

            payslip.taxDeduction = decimal.Divide(salaryService.calculatePeriodSalaryTax(employee, monthlySalary), 2);
            periodSalary -= payslip.taxDeduction;

            payslip.netPay = decimal.Round(periodSalary, 2);
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
