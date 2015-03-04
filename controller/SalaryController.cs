using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using PayrollSystem.service;

namespace PayrollSystem.controller
{
    public class SalaryController : SalaryControllerInterface
    {
        private SalaryServiceInterface salaryService;

        public SalaryController()
        {
            salaryService = new SalaryService();
        }

        public decimal calculateDailyBasedSalaryWithOvertimeRequests(List<Request> overtimeRequests, decimal dailyBasedSalary)
        {
            return salaryService.calculateDailyBasedSalaryWithOvertimeRequests(overtimeRequests, dailyBasedSalary);
        }

        public decimal fetchTotalCashAdvanceAmount(List<Request> cashAdvanceList)
        {
            return salaryService.fetchTotalCashAdvanceAmount(cashAdvanceList);
        }

        public decimal calculateDailBasedSalaryWithLeaveRequest(List<Request> leaveRequests, decimal dailyBasedSalary)
        {
            return salaryService.calculateDailBasedSalaryWithLeaveRequest(leaveRequests, dailyBasedSalary);
        }
    }
}
