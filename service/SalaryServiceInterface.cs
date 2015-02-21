using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
namespace PayrollSystem.service
{
    public interface SalaryServiceInterface
    {
        decimal calculatePeriodSalary(List<Attendance> attendances, decimal dailyBasedSalary);

        decimal calculateDailyBasedSalaryWithOvertimeRequests(List<Request> overtimeRequests, decimal dailyBasedSalary);

        decimal calculateDailBasedSalaryWithLeaveRequest(List<Request> leaveRequests, decimal dailyBasedSalary);

        decimal calculatePeriodSalaryWithDeductions(List<Miscellaneous> deductions, decimal periodSalary);

        decimal calculatePeriodSalaryWithBenefits(List<Miscellaneous> benefits, decimal periodSalary, List<Attendance> attendances, List<Request> leaveRequests);

        decimal calculatePeriodSalaryWithBonus(List<Miscellaneous> bonuses, decimal periodSalary);

        decimal calculatePeriodSalaryTax(Employee employee, decimal periodSalary);

        decimal fetchSssDeductionsWithPeriodSalary(decimal periodSalary);

        decimal fetchPagIbigDeductionWithPeriodSalary(decimal periodSalary);

        decimal fetchPhilHealthDeductionWithPeriodSalary(decimal periodSalary);
    }
}
