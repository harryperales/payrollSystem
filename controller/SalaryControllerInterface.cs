﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface SalaryControllerInterface
    {
        decimal calculateDailyBasedSalaryWithOvertimeRequests(List<Request> overtimeRequests, decimal dailyBasedSalary);

        decimal fetchTotalCashAdvanceAmount(List<Request> cashAdvanceList);

        decimal calculateDailBasedSalaryWithLeaveRequest(List<Request> leaveRequests, decimal dailyBasedSalary);
    }
}
