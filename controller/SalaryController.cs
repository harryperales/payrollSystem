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
    }
}
