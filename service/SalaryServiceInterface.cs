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

        decimal calculatePeriodSalaryWithOvertimeRequests(List<Request> overtimeRequests, decimal dailyBasedSalary);

        decimal calculatePeriodSalaryWithLeaveRequest(List<Request> leaveRequests, decimal dailyBasedSalary);

        decimal calculatePeriodSalaryWithDeductions(List<Miscellaneous> deductions, decimal periodSalary);

        decimal calculatePeriodSalaryWithBenefits(List<Miscellaneous> benefits, decimal periodSalary, List<Attendance> attendances, List<Request> leaveRequests);

        decimal calculatePeriodSalaryWithBonus(List<Miscellaneous> bonuses, decimal periodSalary);

        decimal calculatePeriodSalaryTax(Employee employee, decimal periodSalary);
    }
}
