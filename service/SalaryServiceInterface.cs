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

        decimal fetchTotalDeductions(List<Miscellaneous> deductions);

        decimal fetchTotalAmountOfBenefits(List<Miscellaneous> benefits, List<Attendance> attendances, List<Request> leaveRequests);

        decimal fetchTotalBonus(List<Miscellaneous> bonuses);

        decimal calculatePeriodSalaryTax(Employee employee, decimal periodSalary);

        decimal fetchSssDeductionsWithPeriodSalary(decimal periodSalary);

        decimal fetchPagIbigDeductionWithPeriodSalary(decimal periodSalary);

        decimal fetchPhilHealthDeductionWithPeriodSalary(decimal periodSalary);
    }
}
